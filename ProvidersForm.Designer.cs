namespace Healthcare_API_Client
{
    partial class ProvidersForm
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
            listViewProviders = new ListView();
            confirmBtn = new Button();
            SuspendLayout();
            // 
            // listViewProviders
            // 
            listViewProviders.FullRowSelect = true;
            listViewProviders.GridLines = true;
            listViewProviders.Location = new Point(20, 20);
            listViewProviders.Name = "listViewProviders";
            listViewProviders.Size = new Size(869, 300);
            listViewProviders.TabIndex = 0;
            listViewProviders.UseCompatibleStateImageBehavior = false;
            listViewProviders.View = View.Details;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(200, 340);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(120, 30);
            confirmBtn.TabIndex = 1;
            confirmBtn.Text = "Confirm";
            confirmBtn.Click += ConfirmBtn_Click;
            // 
            // ProvidersForm
            // 
            ClientSize = new Size(928, 400);
            Controls.Add(listViewProviders);
            Controls.Add(confirmBtn);
            Name = "ProvidersForm";
            Text = "Select a Provider";
            ResumeLayout(false);
        }


        #endregion

        private Label label1;
        private Button confirmBtn;
        private ListView listViewProviders;
    }
}