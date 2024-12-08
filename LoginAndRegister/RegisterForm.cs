using Healthcare_API_Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Healthcare_API_Client
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            Dropdowns();
        }

        private void Dropdowns()
        {
            GenderBox.DataSource = Enum.GetValues(typeof(Gender));
            ShiftBox.DataSource = Enum.GetValues(typeof(Shift));
            UserTypeBox.DataSource = Enum.GetValues(typeof(AppUserType));

            UserTypeBox.SelectedIndexChanged += (s, e) => FieldsBasedOnUserType();

        }

        private void FieldsBasedOnUserType()
        {
            var selectedUserType = (AppUserType)UserTypeBox.SelectedItem;

            ShiftLbl.Visible = ShiftBox.Visible = (selectedUserType == AppUserType.Provider);

            GenderLbl.Visible = GenderBox.Visible = (selectedUserType == AppUserType.Patient);
            BirthDateLbl.Visible = BirthDateDTP.Visible = (selectedUserType == AppUserType.Patient);

            AdressLbl.Visible = AdressTxt.Visible = (selectedUserType == AppUserType.Patient);
        }

        private async void RegisterBtn_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text.Trim();
            string userName = UsernameTxt.Text.Trim();
            string email = EmailTxt.Text.Trim();
            string password = PasswordTxt.Text.Trim();
            string confirmPassword = ConfirmPasswordTxt.Text.Trim();
            string address = AdressTxt.Text.Trim();
            AppUserType userType = (AppUserType)UserTypeBox.SelectedItem;
            Gender gender = Gender.Male;  
            Shift shift = Shift.Morning;  
            DateOnly birthDay = default;

            if (userType == AppUserType.Patient)
            {
                gender = (Gender)GenderBox.SelectedItem;
                if (!DateOnly.TryParse(BirthDateDTP.Value.ToShortDateString(), out birthDay))
                {
                    MessageBox.Show("Invalid birth date.");
                    return;
                }
            }

            if (userType == AppUserType.Provider)
            {
                shift = (Shift)ShiftBox.SelectedItem;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            var userRegister = new UserRegister
            {
                Name = string.IsNullOrEmpty(name) ? null : name,
                UserName = userName,
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword,
                Address = string.IsNullOrEmpty(address) ? null : address,
                UserType = userType,
                Gender = userType == AppUserType.Patient ? gender : 0,
                Shift = userType == AppUserType.Provider ? shift : 0,
                BirthDay = userType == AppUserType.Patient ? birthDay : default
            };

            await RegisterUserAsync(userRegister);
        }

        private async Task RegisterUserAsync(UserRegister userRegister)
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
                };

                using (HttpClient client = new HttpClient(handler))
                {
                    string apiUrl = "https://localhost:7024/api/Account/Register";
                    string jsonData = JsonConvert.SerializeObject(userRegister);
                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registration successful! Please check your email for confirmation.");
                    }
                    else
                    {
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Registration failed: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
