namespace WindowsFormsApp1
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
            this.signup_showPass = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_loginBtn = new System.Windows.Forms.Button();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signup_showPass
            // 
            this.signup_showPass.AutoSize = true;
            this.signup_showPass.Location = new System.Drawing.Point(130, 172);
            this.signup_showPass.Name = "signup_showPass";
            this.signup_showPass.Size = new System.Drawing.Size(88, 17);
            this.signup_showPass.TabIndex = 13;
            this.signup_showPass.Text = "Şifreyi Göster";
            this.signup_showPass.UseVisualStyleBackColor = true;
            this.signup_showPass.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(20, 195);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 12;
            this.signup_btn.Text = "Kayıt Ol";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_loginBtn
            // 
            this.signup_loginBtn.Location = new System.Drawing.Point(130, 195);
            this.signup_loginBtn.Name = "signup_loginBtn";
            this.signup_loginBtn.Size = new System.Drawing.Size(106, 23);
            this.signup_loginBtn.TabIndex = 11;
            this.signup_loginBtn.Text = "Logine Geri Dön";
            this.signup_loginBtn.UseVisualStyleBackColor = true;
            this.signup_loginBtn.Click += new System.EventHandler(this.signup_loginBtn_Click);
            // 
            // signup_password
            // 
            this.signup_password.Location = new System.Drawing.Point(29, 114);
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(174, 20);
            this.signup_password.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // signup_username
            // 
            this.signup_username.Location = new System.Drawing.Point(29, 58);
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(174, 20);
            this.signup_username.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 285);
            this.Controls.Add(this.signup_showPass);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.signup_loginBtn);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox signup_showPass;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Button signup_loginBtn;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label1;
    }
}