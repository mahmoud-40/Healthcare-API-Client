namespace Healthcare_API_Client
{
    partial class RecordsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewRecords;
        private System.Windows.Forms.Button closeButton;

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
            listViewRecords = new ListView();
            closeButton = new Button();
            SuspendLayout();
            // 
            // listViewRecords
            // 
            listViewRecords.Location = new Point(14, 16);
            listViewRecords.Margin = new Padding(3, 4, 3, 4);
            listViewRecords.Name = "listViewRecords";
            listViewRecords.Size = new Size(1264, 399);
            listViewRecords.TabIndex = 0;
            listViewRecords.UseCompatibleStateImageBehavior = false;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(568, 433);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(86, 31);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // RecordsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 481);
            Controls.Add(closeButton);
            Controls.Add(listViewRecords);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RecordsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Medical Records";
            ResumeLayout(false);

            SetupListView();
        }

        #endregion

        private void SetupListView()
        {
            listViewRecords.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewRecords.Columns.Add("Provider Name", 150, HorizontalAlignment.Left);
            listViewRecords.Columns.Add("Provider Email", 150, HorizontalAlignment.Left);
            listViewRecords.Columns.Add("Provider Phone", 100, HorizontalAlignment.Left);
            listViewRecords.Columns.Add("Provider Rate", 200, HorizontalAlignment.Left);
            listViewRecords.Columns.Add("Doctor Name", 150, HorizontalAlignment.Left);
            listViewRecords.Columns.Add("Treatments", 200, HorizontalAlignment.Left);
            listViewRecords.Columns.Add("Last Update", 100, HorizontalAlignment.Center);
            listViewRecords.Columns.Add("Since", 100, HorizontalAlignment.Center);

            listViewRecords.View = View.Details;
            listViewRecords.FullRowSelect = true;
            listViewRecords.GridLines = true;
        }
    }
}
