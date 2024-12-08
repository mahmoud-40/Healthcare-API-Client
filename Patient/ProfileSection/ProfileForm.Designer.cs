namespace Healthcare_API_Client
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelMemberSince;

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;

        private System.Windows.Forms.ComboBox comboBoxGender;

        private System.Windows.Forms.Label labelAgeValue;

        private System.Windows.Forms.DateTimePicker datePickerMemberSince;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelMemberSinceValue;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelMemberSince = new System.Windows.Forms.Label();

            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();

            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.datePickerMemberSince = new System.Windows.Forms.DateTimePicker();

            this.labelAgeValue = new System.Windows.Forms.Label();
            this.labelMemberSinceValue = new System.Windows.Forms.Label();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // Label for ID
            this.labelId.Text = "ID:";
            this.labelId.Location = new System.Drawing.Point(30, 30);
            this.labelId.Size = new System.Drawing.Size(100, 20);

            // TextBox for ID (read-only)
            this.textBoxId.Location = new System.Drawing.Point(150, 30);
            this.textBoxId.Size = new System.Drawing.Size(250, 20);
            this.textBoxId.ReadOnly = true;

            // Label for Name
            this.labelName.Text = "Name:";
            this.labelName.Location = new System.Drawing.Point(30, 70);
            this.labelName.Size = new System.Drawing.Size(100, 20);

            // TextBox for Name
            this.textBoxName.Location = new System.Drawing.Point(150, 70);
            this.textBoxName.Size = new System.Drawing.Size(250, 20);

            // Label for Age
            this.labelAge.Text = "Age:";
            this.labelAge.Location = new System.Drawing.Point(30, 110);
            this.labelAge.Size = new System.Drawing.Size(100, 20);

            // Label for Age Value (read-only)
            this.labelAgeValue.Location = new System.Drawing.Point(150, 110);
            this.labelAgeValue.Size = new System.Drawing.Size(250, 20);

            // Label for Address
            this.labelAddress.Text = "Address:";
            this.labelAddress.Location = new System.Drawing.Point(30, 150);
            this.labelAddress.Size = new System.Drawing.Size(100, 20);

            // TextBox for Address
            this.textBoxAddress.Location = new System.Drawing.Point(150, 150);
            this.textBoxAddress.Size = new System.Drawing.Size(250, 20);

            // Label for Gender
            this.labelGender.Text = "Gender:";
            this.labelGender.Location = new System.Drawing.Point(30, 190);
            this.labelGender.Size = new System.Drawing.Size(100, 20);

            // ComboBox for Gender (read-only)
            this.comboBoxGender.Location = new System.Drawing.Point(150, 190);
            this.comboBoxGender.Size = new System.Drawing.Size(250, 20);
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.Enabled = false;

            // Label for Email
            this.labelEmail.Text = "Email:";
            this.labelEmail.Location = new System.Drawing.Point(30, 230);
            this.labelEmail.Size = new System.Drawing.Size(100, 20);

            // TextBox for Email
            this.textBoxEmail.Location = new System.Drawing.Point(150, 230);
            this.textBoxEmail.Size = new System.Drawing.Size(250, 20);

            // Label for Phone Number
            this.labelPhoneNumber.Text = "Phone Number:";
            this.labelPhoneNumber.Location = new System.Drawing.Point(30, 270);
            this.labelPhoneNumber.Size = new System.Drawing.Size(100, 20);

            // TextBox for Phone Number
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(150, 270);
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(250, 20);

            // Label for Member Since
            this.labelMemberSince.Text = "Member Since:";
            this.labelMemberSince.Location = new System.Drawing.Point(30, 310);
            this.labelMemberSince.Size = new System.Drawing.Size(100, 20);

            // Label for Member Since Value (read-only)
            this.labelMemberSinceValue.Location = new System.Drawing.Point(150, 310);
            this.labelMemberSinceValue.Size = new System.Drawing.Size(250, 20);

            // Save Button
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(150, 360);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Cancel Button
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(300, 360);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ProfileForm
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelAgeValue);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelMemberSince);
            this.Controls.Add(this.labelMemberSinceValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Text = "Profile";
        }


        #endregion
    }
}