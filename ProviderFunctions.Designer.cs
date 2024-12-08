namespace Healthcare_API_Client
{
    partial class ProviderFunctions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            checkappointment_btn = new Button();
            mngdoctors_btn = new Button();
            edtprofile_btn = new Button();
            setrecords_btn = new Button();
            schedule_btn = new Button();
            SuspendLayout();
            // 
            // checkappointment_btn
            // 
            checkappointment_btn.Location = new Point(80, 69);
            checkappointment_btn.Name = "checkappointment_btn";
            checkappointment_btn.Size = new Size(177, 43);
            checkappointment_btn.TabIndex = 0;
            checkappointment_btn.Text = "Check Appointment";
            checkappointment_btn.UseVisualStyleBackColor = true;
            // 
            // mngdoctors_btn
            // 
            mngdoctors_btn.Location = new Point(487, 76);
            mngdoctors_btn.Name = "mngdoctors_btn";
            mngdoctors_btn.Size = new Size(158, 36);
            mngdoctors_btn.TabIndex = 1;
            mngdoctors_btn.Text = "Manage Doctors";
            mngdoctors_btn.UseVisualStyleBackColor = true;
            mngdoctors_btn.Click += mngdoctors_btn_Click;
            // 
            // edtprofile_btn
            // 
            edtprofile_btn.Location = new Point(487, 215);
            edtprofile_btn.Name = "edtprofile_btn";
            edtprofile_btn.Size = new Size(155, 38);
            edtprofile_btn.TabIndex = 2;
            edtprofile_btn.Text = "Edit Profile";
            edtprofile_btn.UseVisualStyleBackColor = true;
            edtprofile_btn.Click += edtprofile_btn_Click;
            // 
            // setrecords_btn
            // 
            setrecords_btn.Location = new Point(80, 215);
            setrecords_btn.Name = "setrecords_btn";
            setrecords_btn.Size = new Size(177, 38);
            setrecords_btn.TabIndex = 3;
            setrecords_btn.Text = "Set Records";
            setrecords_btn.UseVisualStyleBackColor = true;
            // 
            // schedule_btn
            // 
            schedule_btn.Location = new Point(298, 333);
            schedule_btn.Name = "schedule_btn";
            schedule_btn.Size = new Size(156, 39);
            schedule_btn.TabIndex = 4;
            schedule_btn.Text = "Schedule";
            schedule_btn.UseVisualStyleBackColor = true;
            // 
            // ProviderFunctions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(schedule_btn);
            Controls.Add(setrecords_btn);
            Controls.Add(edtprofile_btn);
            Controls.Add(mngdoctors_btn);
            Controls.Add(checkappointment_btn);
            Name = "ProviderFunctions";
            Text = "ProviderFunctions";
            Load += ProviderFunctions_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button checkappointment_btn;
        private Button mngdoctors_btn;
        private Button edtprofile_btn;
        private Button setrecords_btn;
        private Button schedule_btn;
    }
}