using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Healthcare_API_Client.Models;
using Newtonsoft.Json;

namespace Healthcare_API_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

<<<<<<< HEAD

        private (string? Id, string? Role) ExtractClaimsFromToken(string token)
       {
        var handler = new JwtSecurityTokenHandler();
        if (!handler.CanReadToken(token))
        {
            throw new ArgumentException("Invalid JWT token");
        }

        var jwtToken = handler.ReadJwtToken(token);

         // Extract claims
           string? id = jwtToken.Claims.FirstOrDefault(c => c.Type == "nameid")?.Value;
           string? role = jwtToken.Claims.FirstOrDefault(c => c.Type == "role")?.Value;

        return (id,role);
         }

     private async void LoginBtn_Click(object sender, EventArgs e)
=======
        private (string? Id, string? Role) ExtractClaimsFromToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            if (!handler.CanReadToken(token))
            {
                throw new ArgumentException("Invalid JWT token");
            }

            var jwtToken = handler.ReadJwtToken(token);

            string? id = jwtToken.Claims.FirstOrDefault(c => c.Type == "nameid")?.Value;
            string? role = jwtToken.Claims.FirstOrDefault(c => c.Type == "role")?.Value;

            return (id, role);
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
>>>>>>> origin/master
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

<<<<<<< HEAD
          
=======

>>>>>>> origin/master
                string jsonData = JsonConvert.SerializeObject(loginData);

                using(HttpClient client = new HttpClient())
                {
                    string apiUrl = "https://localhost:7024/api/Account/Login";

                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
<<<<<<< HEAD
                        // Deserialize response to get the token
                        var loginResp = JsonConvert.DeserializeObject<LoginResponse>(result);

                        // Extract id and role from token
                        var (id, role) = ExtractClaimsFromToken(loginResp.Token);

                        // Check role and navigate to the next form
=======
                        var loginResp = JsonConvert.DeserializeObject<LoginResponse>(result);

                        var (id, role) = ExtractClaimsFromToken(loginResp.Token);

>>>>>>> origin/master
                        if (role == "Provider" && !string.IsNullOrEmpty(id))
                        {
                            MessageBox.Show("Login successful");

                            // Pass id to the next form
<<<<<<< HEAD
                            ProviderFunctions providerFunctionsForm = new ProviderFunctions(id);
                            providerFunctionsForm.Show();
                            this.Hide(); // Hide the login form

                        }
                        else
                        {
                            MessageBox.Show("Unauthorized: This login is not for providers.");
=======
                            //ProviderFunctions providerFunctionsForm = new ProviderFunctions(id);
                            //providerFunctionsForm.Show();
                            //this.Hide(); // Hide the login form

                        }
                        else if (role == "Patient" && !string.IsNullOrEmpty(id))
                        {
                            PatientMain providerFunctionsForm = new PatientMain(id);
                            providerFunctionsForm.Show();
                            this.Hide(); 
                        }
                        else
                        {
                            MessageBox.Show("Admin");
                            PatientMain providerFunctionsForm = new PatientMain(id);
                            providerFunctionsForm.Show();
                            this.Hide();
>>>>>>> origin/master
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login failed: " + response.StatusCode);
                    }
<<<<<<< HEAD
                    }
              }
            
=======
                }
            }

>>>>>>> origin/master
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

