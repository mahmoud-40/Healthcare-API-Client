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
            RegisterBtn.Location = new Point(68, 267);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(94, 29);
            RegisterBtn.TabIndex = 0;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(409, 276);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 29);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UserNameTxt
            // 
            UserNameTxt.Location = new Point(315, 55);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(267, 27);
            UserNameTxt.TabIndex = 2;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(315, 162);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(267, 27);
            PasswordTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 55);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 4;
            label1.Text = "UserName or Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 169);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 358);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTxt);
            Controls.Add(UserNameTxt);
            Controls.Add(LoginBtn);
            Controls.Add(RegisterBtn);
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
