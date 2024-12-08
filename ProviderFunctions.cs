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

namespace Healthcare_API_Client
{
    public partial class ProviderFunctions : Form
    {
        private string providerId;
        public ProviderFunctions(string providerId)
        {
            InitializeComponent();
            this.providerId = providerId;  // Assign the passed providerId to the field


        }

        private void mngdoctors_btn_Click(object sender, EventArgs e)
        {
            ManageDoctors manageDoctorsForm = new ManageDoctors(providerId);
            manageDoctorsForm.ShowDialog();
        }

        private void edtprofile_btn_Click(object sender, EventArgs e)
        {

        }

        private void ProviderFunctions_Load(object sender, EventArgs e)
        {

        }
    }
}
