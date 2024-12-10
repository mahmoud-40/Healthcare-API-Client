using Healthcare_API_Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Healthcare_API_Client.Models.Records;

namespace Healthcare_API_Client
{
    public partial class RecordsForm : Form
    {
        private readonly string patientId;
        private readonly string token;
        private readonly int? doctorId;
        private readonly string? providerId;

        public RecordsForm(string patientId, string token, int? doctorId = null, string? providerId = null)
        {
            InitializeComponent(); 
            this.patientId = patientId;
            this.token = token;
            this.doctorId = doctorId;
            this.providerId = providerId;

            Load += RecordsForm_Load; 
        }

        private async void RecordsForm_Load(object sender, EventArgs e)
        {
            try
            {
                string baseUrl = "https://localhost:7024/api/Patients/medical-records";
                string apiUrl = baseUrl;

                if (doctorId != null)
                {
                    apiUrl += $"?doctorId={doctorId}";
                }
                else if (!string.IsNullOrEmpty(providerId)) // If providerId is not null or empty
                {
                    apiUrl += $"?providerId={providerId}";
                }

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        List<ViewRecordByPatient> records = JsonConvert.DeserializeObject<List<ViewRecordByPatient>>(jsonResponse);

                        if (records != null && records.Count > 0)
                        {
                            RecordsList(records);
                        }
                        else
                        {
                            MessageBox.Show("No records found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Failed to load records: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading records: {ex.Message}");
            }
        }

        private void RecordsList(List<ViewRecordByPatient> records)
        {
            listViewRecords.Items.Clear();

            foreach (var record in records)
            {
                var listViewItem = new ListViewItem(record.Id.ToString());
                listViewItem.SubItems.Add(record.Provider?.Name ?? "N/A");
                listViewItem.SubItems.Add(record.Provider?.Email ?? "N/A");
                listViewItem.SubItems.Add(record.Provider?.PhoneNumber ?? "N/A");
                listViewItem.SubItems.Add(record.Provider?.Rate.ToString() ?? "N/A");
                listViewItem.SubItems.Add(record.Provider?.Doctors[0].FullName ?? "N/A");
                listViewItem.SubItems.Add(record.Treatments ?? "N/A");
                listViewItem.SubItems.Add(record.LastUpdate.ToString());
                listViewItem.SubItems.Add(record.Since.ToString());


                listViewItem.Tag = record;
                listViewRecords.Items.Add(listViewItem);
            }

            listViewRecords.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
