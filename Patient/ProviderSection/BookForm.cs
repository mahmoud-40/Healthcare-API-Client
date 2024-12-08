using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Healthcare_API_Client.Models;

namespace Healthcare_API_Client
{
    public partial class BookForm : Form
    {
        private readonly string patientId;
        private readonly string doctorId; 
        private readonly string token;

        public BookForm(string patientId, string doctorId, string token)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.doctorId = doctorId;
            this.token = token;

            reasonComboBox.SelectedIndex = 0;

            for (int i = 1; i <= 8; i++)
            {
                timeComboBox.Items.Add(i);
            }

            timeComboBox.SelectedIndex = 0; 

            datePicker.Value = DateTime.Now;
        }

        private async void confirmBtn_Click(object? sender, EventArgs e)
        {
            if (reasonComboBox.SelectedIndex == -1 || timeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var appointment = new Appointment
            {
                DoctorId = int.Parse(doctorId), 
                Date = DateOnly.FromDateTime(datePicker.Value),
                Time = (int)timeComboBox.SelectedItem,
                Reason = (Reason)reasonComboBox.SelectedIndex
            };

            try
            {
                string apiUrl = "https://localhost:7024/api/Appointments";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                    string jsonData = JsonConvert.SerializeObject(appointment);
                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed to book appointment: {response.ReasonPhrase}\n{errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
