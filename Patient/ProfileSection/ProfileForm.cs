using Healthcare_API_Client.Models;
using Healthcare_API_Client.Models.Profile;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_API_Client
{
    public partial class ProfileForm : Form
    {
        private readonly string _id;
        private readonly string _token;

        public ProfileForm(string id, string token)
        {
            InitializeComponent();
            _id = id;
            _token = token;
            Load += ProfileForm_Load;
        }

        private async void ProfileForm_Load(object sender, EventArgs e)
        {
            await LoadProfile();
        }

        private async Task LoadProfile()
        {
            try
            {
                string apiUrl = $"https://localhost:7024/api/Patients/profile";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _token);

                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        var profile = JsonConvert.DeserializeObject<PatientProfile>(jsonResponse);

                        if (profile != null)
                        {
                            txtName.Text = profile.Name ?? string.Empty;
                            txtEmail.Text = profile.Email ?? string.Empty;
                            txtAddress.Text = profile.Address ?? string.Empty;
                            txtPhoneNumber.Text = profile.PhoneNumber ?? string.Empty;
                            labelGenderValue.Text = profile.Gender.ToString();

                            if (profile.BirthDay != DateOnly.MinValue)
                            {
                                datePickerBirthDay.Value = profile.BirthDay.ToDateTime(TimeOnly.MinValue);
                            }
                            else
                            {
                                datePickerBirthDay.Value = DateTime.Now;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Failed to load profile: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the profile: {ex.Message}");
            }
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            await UpdateProfile();
        }

        private async Task UpdateProfile()
        {
            try
            {
                string apiUrl = $"https://localhost:7024/api/Patients/profile";

                var updatedProfile = new PatientProfile
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Gender = Enum.Parse<Gender>(labelGenderValue.Text),
                    BirthDay = DateOnly.FromDateTime(datePickerBirthDay.Value) 
                };

                string jsonRequest = JsonConvert.SerializeObject(updatedProfile);

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _token);

                    StringContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Profile updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to update profile: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the profile: {ex.Message}");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
