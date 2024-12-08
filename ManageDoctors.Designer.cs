namespace Healthcare_API_Client
{
    partial class ManageDoctors
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
            listViewDoctors = new ListView();
            SuspendLayout();
            // 
            // listViewDoctors
            // 
            listViewDoctors.Location = new Point(100, 45);
            listViewDoctors.Name = "listViewDoctors";
            listViewDoctors.Size = new Size(602, 360);
            listViewDoctors.TabIndex = 0;
            listViewDoctors.UseCompatibleStateImageBehavior = false;
            // 
            // ManageDoctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewDoctors);
            Name = "ManageDoctors";
            Text = "ManageDoctors";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewDoctors;
    }
}