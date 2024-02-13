namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.greet_user = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.salary_btn = new System.Windows.Forms.Button();
            this.addEmployee_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard1 = new WindowsFormsApp1.Dashboard();
            this.addEmployee1 = new WindowsFormsApp1.AddEmployee();
            this.salary1 = new WindowsFormsApp1.Salary();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.greet_user);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.salary_btn);
            this.panel1.Controls.Add(this.addEmployee_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 561);
            this.panel1.TabIndex = 1;
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Location = new System.Drawing.Point(12, 114);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(52, 13);
            this.greet_user.TabIndex = 5;
            this.greet_user.Text = "Welcome";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 506);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ana Sayfaya Dön";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // salary_btn
            // 
            this.salary_btn.Location = new System.Drawing.Point(15, 240);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.Size = new System.Drawing.Size(152, 35);
            this.salary_btn.TabIndex = 3;
            this.salary_btn.Text = "SALARY";
            this.salary_btn.UseVisualStyleBackColor = true;
            this.salary_btn.Click += new System.EventHandler(this.salary_btn_Click);
            // 
            // addEmployee_btn
            // 
            this.addEmployee_btn.Location = new System.Drawing.Point(15, 199);
            this.addEmployee_btn.Name = "addEmployee_btn";
            this.addEmployee_btn.Size = new System.Drawing.Size(152, 35);
            this.addEmployee_btn.TabIndex = 2;
            this.addEmployee_btn.Text = "ADD EMPOLOYEE";
            this.addEmployee_btn.UseVisualStyleBackColor = true;
            this.addEmployee_btn.Click += new System.EventHandler(this.addEmployee_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Location = new System.Drawing.Point(15, 158);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(152, 35);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashboard1);
            this.panel2.Controls.Add(this.addEmployee1);
            this.panel2.Controls.Add(this.salary1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 561);
            this.panel2.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(-3, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(884, 565);
            this.dashboard1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(881, 565);
            this.addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(881, 565);
            this.salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addEmployee_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button salary_btn;
        private System.Windows.Forms.Panel panel2;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
        private Salary salary1;
        private System.Windows.Forms.Label greet_user;
    }
}