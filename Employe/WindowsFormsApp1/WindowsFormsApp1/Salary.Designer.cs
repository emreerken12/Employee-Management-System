namespace WindowsFormsApp1
{
    partial class Salary
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.salary_employeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salary_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salary_position = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salary_salary = new System.Windows.Forms.TextBox();
            this.salary_updateBtn = new System.Windows.Forms.Button();
            this.salary_clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 486);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee ID:";
            // 
            // salary_employeeID
            // 
            this.salary_employeeID.Location = new System.Drawing.Point(98, 75);
            this.salary_employeeID.Name = "salary_employeeID";
            this.salary_employeeID.Size = new System.Drawing.Size(167, 20);
            this.salary_employeeID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Full Name:";
            // 
            // salary_name
            // 
            this.salary_name.Location = new System.Drawing.Point(98, 121);
            this.salary_name.Name = "salary_name";
            this.salary_name.Size = new System.Drawing.Size(167, 20);
            this.salary_name.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Position";
            // 
            // salary_position
            // 
            this.salary_position.Location = new System.Drawing.Point(98, 170);
            this.salary_position.Name = "salary_position";
            this.salary_position.Size = new System.Drawing.Size(167, 20);
            this.salary_position.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Salary:";
            // 
            // salary_salary
            // 
            this.salary_salary.Location = new System.Drawing.Point(98, 220);
            this.salary_salary.Name = "salary_salary";
            this.salary_salary.Size = new System.Drawing.Size(167, 20);
            this.salary_salary.TabIndex = 12;
            // 
            // salary_updateBtn
            // 
            this.salary_updateBtn.Location = new System.Drawing.Point(20, 272);
            this.salary_updateBtn.Name = "salary_updateBtn";
            this.salary_updateBtn.Size = new System.Drawing.Size(100, 30);
            this.salary_updateBtn.TabIndex = 19;
            this.salary_updateBtn.Text = "Update";
            this.salary_updateBtn.UseVisualStyleBackColor = true;
            this.salary_updateBtn.Click += new System.EventHandler(this.salary_updateBtn_Click);
            // 
            // salary_clearBtn
            // 
            this.salary_clearBtn.Location = new System.Drawing.Point(136, 272);
            this.salary_clearBtn.Name = "salary_clearBtn";
            this.salary_clearBtn.Size = new System.Drawing.Size(100, 30);
            this.salary_clearBtn.TabIndex = 18;
            this.salary_clearBtn.Text = "Clear";
            this.salary_clearBtn.UseVisualStyleBackColor = true;
            this.salary_clearBtn.Click += new System.EventHandler(this.salary_clearBtn_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salary_updateBtn);
            this.Controls.Add(this.salary_clearBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salary_salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salary_position);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salary_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salary_employeeID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(875, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salary_employeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salary_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salary_position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salary_salary;
        private System.Windows.Forms.Button salary_updateBtn;
        private System.Windows.Forms.Button salary_clearBtn;
    }
}
