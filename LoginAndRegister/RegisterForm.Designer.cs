namespace Healthcare_API_Client
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            UsernameTxt = new TextBox();
            NameTxt = new TextBox();
            EmailTxt = new TextBox();
            PasswordTxt = new TextBox();
            ConfirmPasswordTxt = new TextBox();
            UserTypeBox = new ComboBox();
            GenderBox = new ComboBox();
            ShiftBox = new ComboBox();
            AdressTxt = new TextBox();
            BirthDateDTP = new DateTimePicker();
            RegisterBtn = new Button();
            UserName = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            GenderLbl = new Label();
            ShiftLbl = new Label();
            AdressLbl = new Label();
            BirthDateLbl = new Label();
            SuspendLayout();
            // 
            // UsernameTxt
            // 
            UsernameTxt.BackColor = SystemColors.ControlLight;
            UsernameTxt.Location = new Point(319, 51);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(125, 27);
            UsernameTxt.TabIndex = 0;
            // 
            // NameTxt
            // 
            NameTxt.BackColor = SystemColors.ControlLight;
            NameTxt.Location = new Point(319, 104);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(125, 27);
            NameTxt.TabIndex = 1;
            // 
            // EmailTxt
            // 
            EmailTxt.BackColor = SystemColors.Control;
            EmailTxt.Location = new Point(319, 165);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(125, 27);
            EmailTxt.TabIndex = 2;
            // 
            // PasswordTxt
            // 
            PasswordTxt.BackColor = SystemColors.Control;
            PasswordTxt.Location = new Point(319, 219);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(125, 27);
            PasswordTxt.TabIndex = 3;
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.BackColor = SystemColors.Control;
            ConfirmPasswordTxt.Location = new Point(319, 277);
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.Size = new Size(125, 27);
            ConfirmPasswordTxt.TabIndex = 4;
            // 
            // UserTypeBox
            // 
            UserTypeBox.BackColor = SystemColors.Control;
            UserTypeBox.FormattingEnabled = true;
            UserTypeBox.Location = new Point(654, 103);
            UserTypeBox.Name = "UserTypeBox";
            UserTypeBox.Size = new Size(239, 28);
            UserTypeBox.TabIndex = 5;
            // 
            // GenderBox
            // 
            GenderBox.BackColor = SystemColors.Control;
            GenderBox.FormattingEnabled = true;
            GenderBox.Location = new Point(657, 165);
            GenderBox.Name = "GenderBox";
            GenderBox.Size = new Size(239, 28);
            GenderBox.TabIndex = 6;
            // 
            // ShiftBox
            // 
            ShiftBox.BackColor = SystemColors.Control;
            ShiftBox.FormattingEnabled = true;
            ShiftBox.Location = new Point(654, 218);
            ShiftBox.Name = "ShiftBox";
            ShiftBox.Size = new Size(242, 28);
            ShiftBox.TabIndex = 7;
            // 
            // AdressTxt
            // 
            AdressTxt.BackColor = SystemColors.Control;
            AdressTxt.Location = new Point(651, 52);
            AdressTxt.Name = "AdressTxt";
            AdressTxt.Size = new Size(239, 27);
            AdressTxt.TabIndex = 8;
            // 
            // BirthDateDTP
            // 
            BirthDateDTP.Location = new Point(654, 279);
            BirthDateDTP.Name = "BirthDateDTP";
            BirthDateDTP.Size = new Size(242, 27);
            BirthDateDTP.TabIndex = 9;
            // 
            // RegisterBtn
            // 
            RegisterBtn.FlatStyle = FlatStyle.System;
            RegisterBtn.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold);
            RegisterBtn.Location = new Point(691, 334);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(176, 47);
            RegisterBtn.TabIndex = 10;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(26, 51);
            UserName.Name = "UserName";
            UserName.Size = new Size(78, 20);
            UserName.TabIndex = 11;
            UserName.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 103);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 165);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 222);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(525, 107);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 15;
            label4.Text = "User Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 284);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 16;
            label5.Text = "Confirm Password";
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.Location = new Point(528, 165);
            GenderLbl.Name = "GenderLbl";
            GenderLbl.Size = new Size(57, 20);
            GenderLbl.TabIndex = 17;
            GenderLbl.Text = "Gender";
            // 
            // ShiftLbl
            // 
            ShiftLbl.AutoSize = true;
            ShiftLbl.Location = new Point(528, 230);
            ShiftLbl.Name = "ShiftLbl";
            ShiftLbl.Size = new Size(39, 20);
            ShiftLbl.TabIndex = 18;
            ShiftLbl.Text = "Shift";
            // 
            // AdressLbl
            // 
            AdressLbl.AutoSize = true;
            AdressLbl.Location = new Point(528, 49);
            AdressLbl.Name = "AdressLbl";
            AdressLbl.Size = new Size(53, 20);
            AdressLbl.TabIndex = 19;
            AdressLbl.Text = "Adress";
            // 
            // BirthDateLbl
            // 
            BirthDateLbl.AutoSize = true;
            BirthDateLbl.Location = new Point(525, 284);
            BirthDateLbl.Name = "BirthDateLbl";
            BirthDateLbl.Size = new Size(76, 20);
            BirthDateLbl.TabIndex = 20;
            BirthDateLbl.Text = "Birth Date";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 396);
            Controls.Add(BirthDateLbl);
            Controls.Add(AdressLbl);
            Controls.Add(ShiftLbl);
            Controls.Add(GenderLbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(UserName);
            Controls.Add(RegisterBtn);
            Controls.Add(BirthDateDTP);
            Controls.Add(AdressTxt);
            Controls.Add(ShiftBox);
            Controls.Add(GenderBox);
            Controls.Add(UserTypeBox);
            Controls.Add(ConfirmPasswordTxt);
            Controls.Add(PasswordTxt);
            Controls.Add(EmailTxt);
            Controls.Add(NameTxt);
            Controls.Add(UsernameTxt);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTxt;
        private TextBox NameTxt;
        private TextBox EmailTxt;
        private TextBox PasswordTxt;
        private TextBox ConfirmPasswordTxt;
        private ComboBox UserTypeBox;
        private ComboBox GenderBox;
        private ComboBox ShiftBox;
        private TextBox AdressTxt;
        private DateTimePicker BirthDateDTP;
        private Button RegisterBtn;
        private Label UserName;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label GenderLbl;
        private Label ShiftLbl;
        private Label AdressLbl;
        private Label BirthDateLbl;
    }
}