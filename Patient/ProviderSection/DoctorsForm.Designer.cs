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
            listViewDoctors = new ListView();
            confirmBtn = new Button();
            SuspendLayout();
            // 
            // listViewDoctors
            // 
            listViewDoctors.FullRowSelect = true;
            listViewDoctors.GridLines = true;
            listViewDoctors.Location = new Point(12, 44);
            listViewDoctors.Name = "listViewDoctors";
            listViewDoctors.Size = new Size(869, 300);
            listViewDoctors.TabIndex = 2;
            listViewDoctors.UseCompatibleStateImageBehavior = false;
            listViewDoctors.View = View.Details;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(369, 378);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(120, 30);
            confirmBtn.TabIndex = 3;
            confirmBtn.Text = "Confirm";
            confirmBtn.Click += confirmBtn_Click;
            // 
            // DoctorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(listViewDoctors);
            Controls.Add(confirmBtn);
            Name = "DoctorsForm";
            Text = "DoctorsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewDoctors;
        private Button confirmBtn;
    }
}