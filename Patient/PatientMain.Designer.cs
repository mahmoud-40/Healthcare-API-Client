namespace Healthcare_API_Client
{
    partial class PatientMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMain));
            ProvidersBtn = new Button();
            ProfileBtn = new Button();
            RecordsBtn = new Button();
            SuspendLayout();
            // 
            // ProvidersBtn
            // 
            ProvidersBtn.BackColor = SystemColors.ControlDark;
            ProvidersBtn.FlatStyle = FlatStyle.System;
            ProvidersBtn.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold);
            ProvidersBtn.Location = new Point(125, 80);
            ProvidersBtn.Name = "ProvidersBtn";
            ProvidersBtn.Size = new Size(344, 49);
            ProvidersBtn.TabIndex = 0;
            ProvidersBtn.Text = "Providers";
            ProvidersBtn.UseVisualStyleBackColor = false;
            ProvidersBtn.Click += ProvidersBtn_Click;
            // 
            // ProfileBtn
            // 
            ProfileBtn.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold);
            ProfileBtn.Location = new Point(125, 174);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(344, 47);
            ProfileBtn.TabIndex = 1;
            ProfileBtn.Text = "Profile";
            ProfileBtn.UseVisualStyleBackColor = true;
            ProfileBtn.Click += ProfileBtn_Click;
            // 
            // RecordsBtn
            // 
            RecordsBtn.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold);
            RecordsBtn.Location = new Point(125, 259);
            RecordsBtn.Name = "RecordsBtn";
            RecordsBtn.Size = new Size(344, 47);
            RecordsBtn.TabIndex = 2;
            RecordsBtn.Text = "Records";
            RecordsBtn.UseVisualStyleBackColor = true;
            RecordsBtn.Click += RecordsBtn_Click;
            // 
            // PatientMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(618, 359);
            Controls.Add(RecordsBtn);
            Controls.Add(ProfileBtn);
            Controls.Add(ProvidersBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PatientMain";
            Text = "Patient Main";
            ResumeLayout(false);
        }

        #endregion

        private Button ProvidersBtn;
        private Button ProfileBtn;
        private Button RecordsBtn;
    }
}