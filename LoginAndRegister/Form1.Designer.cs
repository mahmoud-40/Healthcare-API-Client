namespace Healthcare_API_Client
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            RegisterBtn = new Button();
            LoginBtn = new Button();
            UserNameTxt = new TextBox();
            PasswordTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = SystemColors.ActiveCaption;
            RegisterBtn.BackgroundImageLayout = ImageLayout.Zoom;
            RegisterBtn.FlatStyle = FlatStyle.System;
            RegisterBtn.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold);
            RegisterBtn.Location = new Point(76, 231);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(152, 45);
            RegisterBtn.TabIndex = 0;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ActiveCaption;
            LoginBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LoginBtn.FlatStyle = FlatStyle.System;
            LoginBtn.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(338, 231);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(161, 45);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UserNameTxt
            // 
            UserNameTxt.BackColor = SystemColors.ButtonHighlight;
            UserNameTxt.BorderStyle = BorderStyle.FixedSingle;
            UserNameTxt.Location = new Point(338, 151);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(161, 27);
            UserNameTxt.TabIndex = 2;
            // 
            // PasswordTxt
            // 
            PasswordTxt.BackColor = SystemColors.ButtonHighlight;
            PasswordTxt.BorderStyle = BorderStyle.FixedSingle;
            PasswordTxt.Location = new Point(338, 69);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(161, 27);
            PasswordTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuBar;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 73);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 4;
            label1.Text = "Username / Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.MenuBar;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            label2.Location = new Point(76, 160);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(568, 344);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTxt);
            Controls.Add(UserNameTxt);
            Controls.Add(LoginBtn);
            Controls.Add(RegisterBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterBtn;
        private Button LoginBtn;
        private TextBox UserNameTxt;
        private TextBox PasswordTxt;
        private Label label1;
        private Label label2;
    }
}
