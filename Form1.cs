using System.Text;
using Newtonsoft.Json;

namespace Healthcare_API_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserNameTxt.Text.Trim();
            string password = PasswordTxt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                var loginData = new { userName = username, password = password };
                string jsonData = JsonConvert.SerializeObject(loginData);

                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "https://localhost:7024/api/Account/Login";
                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Login successful: " + result);
                    }
                    else
                    {
                        MessageBox.Show("Login failed: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}

