using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healthcare_API_Client.Models;
using System.Xml.Linq;
using Healthcare_API_Client.Models.Profile;
using Newtonsoft.Json;

namespace Healthcare_API_Client
{
    public partial class ProfileForm : Form
    {
        private readonly string _id;
        private readonly string _token;

        public ProfileForm(string id, string token)
        {
            _id = id;
            _token = token;
            InitializeComponent();
            LoadProfileData();
        }

        private async void LoadProfileData()
        {
            try
            {
                string apiUrl = $"https://localhost:7024/api/Patients/{_id}/profile";

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
                            textBoxName.Text = profile.Name;
                            textBoxAddress.Text = profile.Address;
                            textBoxEmail.Text = profile.Email;
                            textBoxPhoneNumber.Text = profile.PhoneNumber;
                            comboBoxGender.Text = profile.Gender.ToString();
                            labelMemberSinceValue.Text = profile.MemberSince.ToString(@"d\:hh\:mm");
                            labelAgeValue.Text = profile.Age.ToString();
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

        private async void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                var updatedProfile = new
                {
                    name = textBoxName.Text,
                    email = textBoxEmail.Text,
                    birthDay = DateTime.Now.AddYears(-int.Parse(labelAgeValue.Text)).ToString("yyyy-MM-dd"), // Calculate birthdate from age
                    address = textBoxAddress.Text,
                    gender = (int)Enum.Parse(typeof(Gender), comboBoxGender.Text),  
                    phoneNumber = textBoxPhoneNumber.Text
                };

                string apiUrl = $"https://localhost:7024/api/Patients/profile";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _token);
                    string jsonContent = JsonConvert.SerializeObject(updatedProfile);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Profile updated successfully!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to update profile: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the profile: {ex.Message}");
            }
        }


        private void btnCancel_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
