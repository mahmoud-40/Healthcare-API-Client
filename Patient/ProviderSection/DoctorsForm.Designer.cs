namespace Healthcare_API_Client
{
    partial class DoctorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsForm));
            listViewDoctors = new ListView();
            confirmBtn = new Button();
            SuspendLayout();
            // 
            // listViewDoctors
            // 
            listViewDoctors.FullRowSelect = true;
            listViewDoctors.GridLines = true;
            listViewDoctors.Location = new Point(12, 26);
            listViewDoctors.Name = "listViewDoctors";
            listViewDoctors.Size = new Size(869, 336);
            listViewDoctors.TabIndex = 2;
            listViewDoctors.UseCompatibleStateImageBehavior = false;
            listViewDoctors.View = View.Details;
            // 
            // confirmBtn
            // 
            confirmBtn.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold);
            confirmBtn.Location = new Point(383, 378);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(120, 60);
            confirmBtn.TabIndex = 3;
            confirmBtn.Text = "Confirm";
            confirmBtn.Click += confirmBtn_Click;
            // 
            // DoctorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(894, 450);
            Controls.Add(listViewDoctors);
            Controls.Add(confirmBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoctorsForm";
            Text = "Select a Doctor";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewDoctors;
        private Button confirmBtn;
    }
}