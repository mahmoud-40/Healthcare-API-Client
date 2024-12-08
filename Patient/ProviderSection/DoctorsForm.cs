using Healthcare_API_Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace Healthcare_API_Client
{
    public partial class DoctorsForm : Form
    {
        private string id; // patient id => the one who login
        private string providerId;
        string token;
        public DoctorsForm(string id, string providerId, string token)
        {
            InitializeComponent();
            this.id = id;
            this.providerId = providerId;
            this.token = token;

            SetupListView();
            Load += DoctorsForm_Load;
        }

        private async void DoctorsForm_Load(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = $"https://localhost:7024/api/Providers/{providerId}/doctors";

                //MessageBox.Show($"{apiUrl}");


                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        List<Doctor> doctors = JsonConvert.DeserializeObject<List<Doctor>>(jsonResponse);

                        if (doctors != null && doctors.Count > 0)
                        {
                            PopulateDoctorsList(doctors);
                        }
                        else
                        {
                            MessageBox.Show("No doctors found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Failed to load doctors: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading doctors: {ex.Message}");
            }
        }

        private void SetupListView()
        {
            listViewDoctors.Columns.Add("Name", 150, HorizontalAlignment.Left);
            listViewDoctors.Columns.Add("ProviderName", 100, HorizontalAlignment.Left);
            listViewDoctors.Columns.Add("Title", 150, HorizontalAlignment.Left);
            listViewDoctors.Columns.Add("HireDate", 100, HorizontalAlignment.Center);
            listViewDoctors.Columns.Add("YearExperience", 100, HorizontalAlignment.Center);

            listViewDoctors.View = View.Details;
            listViewDoctors.FullRowSelect = true;
            listViewDoctors.GridLines = true;
        }

        private void PopulateDoctorsList(List<Doctor> doctors)
        {
            listViewDoctors.Items.Clear();

            foreach (var doctor in doctors)
            {
                var listViewItem = new ListViewItem(doctor.FullName);
                listViewItem.SubItems.Add(doctor.ProviderName);
                listViewItem.SubItems.Add(doctor.Title);
                listViewItem.SubItems.Add(doctor.HireDate.ToShortDateString());
                listViewItem.SubItems.Add(doctor.YearExperience.ToString());

                listViewItem.Tag = doctor;  
                listViewDoctors.Items.Add(listViewItem);
            }

            listViewDoctors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (listViewDoctors.SelectedItems.Count > 0)
            {
                var selectedItem = listViewDoctors.SelectedItems[0];
                var selectedDoctor = (Doctor)selectedItem.Tag;

                //MessageBox.Show($"You selected {selectedDoctor.FullName}. Proceeding...");

                BookForm bookForm = new BookForm(id, selectedDoctor.Id, token);

                bookForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a doctor before proceeding.");
            }
        }
    }
}
