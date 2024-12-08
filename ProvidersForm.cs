using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Numerics;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healthcare_API_Client.Models;
using Newtonsoft.Json;

namespace Healthcare_API_Client
{
    public partial class ProvidersForm : Form
    {
        private string _id;
        public ProvidersForm(string id)
        {
            InitializeComponent();
            SetupListView();
            Load += ProvidersForm_Load;
            this._id = id;
        }

        private async void ProvidersForm_Load(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = "https://localhost:7024/api/Providers";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        List<Provider> providers = JsonConvert.DeserializeObject<List<Provider>>(jsonResponse);

                        if (providers != null && providers.Count > 0)
                        {
                            foreach (var provider in providers)
                            {
                                var listViewItem = new ListViewItem(provider.Name);
                                listViewItem.SubItems.Add(provider.Email);
                                listViewItem.SubItems.Add(provider.MemberSince.ToString());
                                listViewItem.SubItems.Add(provider.Shift.ToString());
                                listViewItem.SubItems.Add(provider.Rate.ToString());

                                listViewItem.Tag = provider;

                                listViewProviders.Items.Add(listViewItem);
                            }

                            listViewProviders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        }
                        else
                        {
                            MessageBox.Show("No providers found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Failed to load providers: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading providers: {ex.Message}");
            }
        }

        private void SetupListView()
        {
            // Define columns for ListView
            listViewProviders.Columns.Add("Name", 150, HorizontalAlignment.Left);
            listViewProviders.Columns.Add("Email", 100, HorizontalAlignment.Left);
            listViewProviders.Columns.Add("MemberSince", 150, HorizontalAlignment.Left);
            listViewProviders.Columns.Add("Shift", 100, HorizontalAlignment.Center);
            listViewProviders.Columns.Add("Rate", 100, HorizontalAlignment.Center);

            listViewProviders.View = View.Details;
        }


        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (listViewProviders.SelectedItems.Count > 0)
            {
                var selectedItem = listViewProviders.SelectedItems[0];
                var selectedProvider = (Provider)selectedItem.Tag;

                MessageBox.Show($"You selected {selectedProvider.Name}. Proceeding...");
            }
            else
            {
                MessageBox.Show("Please select a provider before proceeding.");
            }
        }
    }
}
