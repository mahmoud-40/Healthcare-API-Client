using Healthcare_API_Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_API_Client
{
    public partial class ManageDoctors : Form
    {
        private string providerId;  // Assuming providerId is passed to this form

        public ManageDoctors(string providerId)
        {

            InitializeComponent();
            this.providerId = providerId;
            SetupListView();

        }

        private void SetupListView()
        {
            // Define columns for ListView
            listViewDoctors.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewDoctors.Columns.Add("Full Name", 150, HorizontalAlignment.Left);
            listViewDoctors.Columns.Add("Title", 100, HorizontalAlignment.Left);
            listViewDoctors.Columns.Add("Provider", 150, HorizontalAlignment.Left);
            listViewDoctors.Columns.Add("Hire Date", 100, HorizontalAlignment.Center);
            listViewDoctors.Columns.Add("Years of Experience", 100, HorizontalAlignment.Center);

            // Set the View to Details (like DataGridView)
            listViewDoctors.View = View.Details;
        }

        // Load doctors from the API
        private async Task LoadDoctors(string providerId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://localhost:7024/api/providers/{providerId}/doctors";  // Replace with your actual API URL
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();
                        List<ViewDoctor> doctors = JsonConvert.DeserializeObject<List<ViewDoctor>>(jsonData);

                        // Clear existing data before adding new items
                        listViewDoctors.Items.Clear();

                        // Populate the ListView with doctor data
                        foreach (var doctor in doctors)
                        {
                            var listViewItem = new ListViewItem(doctor.Id.ToString());  // First column: ID
                            listViewItem.SubItems.Add(doctor.FullName);                  // Second column: Full Name
                            listViewItem.SubItems.Add(doctor.Title);                     // Third column: Title
                            listViewItem.SubItems.Add(doctor.ProviderName);              // Fourth column: Provider Name
                            listViewItem.SubItems.Add(doctor.HireDate.ToString("yyyy-MM-dd"));  // Fifth column: Hire Date (formatted)
                            listViewItem.SubItems.Add(doctor.YearExperience.ToString());        // Sixth column: Years of Experience

                            listViewDoctors.Items.Add(listViewItem);  // Add the item to the ListView
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Failed to load doctors. Status: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // Handle the form load event to fetch doctors
        private async void ManageDoctorsForm_Load(object sender, EventArgs e)
        {
            await LoadDoctors(providerId); // Fetch and display doctors based on providerId
        }

        // Alternatively, fetch doctors when the button is clicked
        private async void btnShowDoctors_Click(object sender, EventArgs e)
        {
            await LoadDoctors(providerId); // Fetch and display doctors based on providerId
        }

     
    }

}
