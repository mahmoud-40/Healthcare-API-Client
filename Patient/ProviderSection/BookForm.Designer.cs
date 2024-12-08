using Healthcare_API_Client.Models;

namespace Healthcare_API_Client
{
    partial class BookForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox reasonComboBox;
        private ComboBox timeComboBox;
        private DateTimePicker datePicker;
        private Button confirmBtn;
        private Button cancelBtn;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                // Dispose of any additional components here
                if (reasonComboBox != null)
                {
                    reasonComboBox.Dispose();
                }
                if (timeComboBox != null)
                {
                    timeComboBox.Dispose();
                }
                if (datePicker != null)
                {
                    datePicker.Dispose();
                }
                if (confirmBtn != null)
                {
                    confirmBtn.Dispose();
                }
                if (cancelBtn != null)
                {
                    cancelBtn.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            reasonComboBox = new ComboBox();
            timeComboBox = new ComboBox();
            datePicker = new DateTimePicker();
            confirmBtn = new Button();
            cancelBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // reasonComboBox
            // 
            reasonComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            reasonComboBox.FormattingEnabled = true;
            reasonComboBox.Items.AddRange(new object[] { "Checkup", "FollowUp", "Emergency" });
            reasonComboBox.Location = new Point(227, 111);
            reasonComboBox.Margin = new Padding(4, 5, 4, 5);
            reasonComboBox.Name = "reasonComboBox";
            reasonComboBox.Size = new Size(332, 28);
            reasonComboBox.TabIndex = 0;
            // 
            // timeComboBox
            // 
            timeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            timeComboBox.FormattingEnabled = true;
            timeComboBox.Location = new Point(227, 169);
            timeComboBox.Margin = new Padding(4, 5, 4, 5);
            timeComboBox.Name = "timeComboBox";
            timeComboBox.Size = new Size(332, 28);
            timeComboBox.TabIndex = 1;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(227, 46);
            datePicker.Margin = new Padding(4, 5, 4, 5);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(332, 27);
            datePicker.TabIndex = 2;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(227, 231);
            confirmBtn.Margin = new Padding(4, 5, 4, 5);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(133, 46);
            confirmBtn.TabIndex = 3;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(427, 231);
            cancelBtn.Margin = new Padding(4, 5, 4, 5);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(133, 46);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 51);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 5;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 172);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 6;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 111);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "Reason";
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 308);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(datePicker);
            Controls.Add(timeComboBox);
            Controls.Add(reasonComboBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BookForm";
            Text = "Book Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
    }
}
