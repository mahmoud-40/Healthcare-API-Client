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
    public partial class PatientMain : Form
    {
        private string id;
        public PatientMain(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ProvidersBtn_Click(object sender, EventArgs e)
        {
            ProvidersForm providersForm = new ProvidersForm(id);
            providersForm.Show();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(id);
            profileForm.Show();
        }

        private void RecordsBtn_Click(object sender, EventArgs e)
        {
            RecordsForm recordsForm = new RecordsForm(id);
            recordsForm.Show();
        }
    }
}
