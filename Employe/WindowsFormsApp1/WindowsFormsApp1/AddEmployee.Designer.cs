namespace WindowsFormsApp1
{
    partial class AddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addEmpoloyee_id = new System.Windows.Forms.TextBox();
            this.addEmpoloyee_fullName = new System.Windows.Forms.TextBox();
            this.addEmpoloyee_gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmpoloyee_position = new System.Windows.Forms.ComboBox();
            this.addEmpoloyee_phoneNumber = new System.Windows.Forms.TextBox();
            this.addEmpoloyee_picture = new System.Windows.Forms.PictureBox();
            this.addEmpoloyee_importBtn = new System.Windows.Forms.Button();
            this.addEmpoloyee_addBtn = new System.Windows.Forms.Button();
            this.addEmpoloyee_updateBtn = new System.Windows.Forms.Button();
            this.addEmpoloyee_clearBtn = new System.Windows.Forms.Button();
            this.addEmpoloyee_deleteBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmpoloyee_status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmpoloyee_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addEmpoloyee_id
            // 
            this.addEmpoloyee_id.Location = new System.Drawing.Point(134, 267);
            this.addEmpoloyee_id.Name = "addEmpoloyee_id";
            this.addEmpoloyee_id.Size = new System.Drawing.Size(167, 20);
            this.addEmpoloyee_id.TabIndex = 2;
            // 
            // addEmpoloyee_fullName
            // 
            this.addEmpoloyee_fullName.Location = new System.Drawing.Point(134, 323);
            this.addEmpoloyee_fullName.Name = "addEmpoloyee_fullName";
            this.addEmpoloyee_fullName.Size = new System.Drawing.Size(167, 20);
            this.addEmpoloyee_fullName.TabIndex = 3;
            // 
            // addEmpoloyee_gender
            // 
            this.addEmpoloyee_gender.FormattingEnabled = true;
            this.addEmpoloyee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.addEmpoloyee_gender.Location = new System.Drawing.Point(134, 377);
            this.addEmpoloyee_gender.Name = "addEmpoloyee_gender";
            this.addEmpoloyee_gender.Size = new System.Drawing.Size(167, 21);
            this.addEmpoloyee_gender.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender:";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(354, 330);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(47, 13);
            this.Position.TabIndex = 11;
            this.Position.Text = "Position:";
            this.Position.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone:";
            // 
            // addEmpoloyee_position
            // 
            this.addEmpoloyee_position.FormattingEnabled = true;
            this.addEmpoloyee_position.Items.AddRange(new object[] {
            "Business Management",
            "Front-End Developer",
            "Back-End Developer",
            "Data Administrator",
            "UI/UX Design",
            ""});
            this.addEmpoloyee_position.Location = new System.Drawing.Point(410, 322);
            this.addEmpoloyee_position.Name = "addEmpoloyee_position";
            this.addEmpoloyee_position.Size = new System.Drawing.Size(167, 21);
            this.addEmpoloyee_position.TabIndex = 9;
            // 
            // addEmpoloyee_phoneNumber
            // 
            this.addEmpoloyee_phoneNumber.Location = new System.Drawing.Point(410, 268);
            this.addEmpoloyee_phoneNumber.Name = "addEmpoloyee_phoneNumber";
            this.addEmpoloyee_phoneNumber.Size = new System.Drawing.Size(167, 20);
            this.addEmpoloyee_phoneNumber.TabIndex = 8;
            // 
            // addEmpoloyee_picture
            // 
            this.addEmpoloyee_picture.Location = new System.Drawing.Point(748, 267);
            this.addEmpoloyee_picture.Name = "addEmpoloyee_picture";
            this.addEmpoloyee_picture.Size = new System.Drawing.Size(100, 104);
            this.addEmpoloyee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmpoloyee_picture.TabIndex = 12;
            this.addEmpoloyee_picture.TabStop = false;
            // 
            // addEmpoloyee_importBtn
            // 
            this.addEmpoloyee_importBtn.Location = new System.Drawing.Point(748, 385);
            this.addEmpoloyee_importBtn.Name = "addEmpoloyee_importBtn";
            this.addEmpoloyee_importBtn.Size = new System.Drawing.Size(100, 30);
            this.addEmpoloyee_importBtn.TabIndex = 13;
            this.addEmpoloyee_importBtn.Text = "Import";
            this.addEmpoloyee_importBtn.UseVisualStyleBackColor = true;
            this.addEmpoloyee_importBtn.Click += new System.EventHandler(this.addEmpoloyee_importBtn_Click);
            // 
            // addEmpoloyee_addBtn
            // 
            this.addEmpoloyee_addBtn.Location = new System.Drawing.Point(39, 473);
            this.addEmpoloyee_addBtn.Name = "addEmpoloyee_addBtn";
            this.addEmpoloyee_addBtn.Size = new System.Drawing.Size(100, 30);
            this.addEmpoloyee_addBtn.TabIndex = 14;
            this.addEmpoloyee_addBtn.Text = "Add";
            this.addEmpoloyee_addBtn.UseVisualStyleBackColor = true;
            this.addEmpoloyee_addBtn.Click += new System.EventHandler(this.addEmpoloyee_addBtn_Click);
            // 
            // addEmpoloyee_updateBtn
            // 
            this.addEmpoloyee_updateBtn.Location = new System.Drawing.Point(159, 473);
            this.addEmpoloyee_updateBtn.Name = "addEmpoloyee_updateBtn";
            this.addEmpoloyee_updateBtn.Size = new System.Drawing.Size(100, 30);
            this.addEmpoloyee_updateBtn.TabIndex = 15;
            this.addEmpoloyee_updateBtn.Text = "Update";
            this.addEmpoloyee_updateBtn.UseVisualStyleBackColor = true;
            this.addEmpoloyee_updateBtn.Click += new System.EventHandler(this.addEmpoloyee_updateBtn_Click);
            // 
            // addEmpoloyee_clearBtn
            // 
            this.addEmpoloyee_clearBtn.Location = new System.Drawing.Point(405, 473);
            this.addEmpoloyee_clearBtn.Name = "addEmpoloyee_clearBtn";
            this.addEmpoloyee_clearBtn.Size = new System.Drawing.Size(100, 30);
            this.addEmpoloyee_clearBtn.TabIndex = 17;
            this.addEmpoloyee_clearBtn.Text = "Clear";
            this.addEmpoloyee_clearBtn.UseVisualStyleBackColor = true;
            this.addEmpoloyee_clearBtn.Click += new System.EventHandler(this.addEmpoloyee_clearBtn_Click);
            // 
            // addEmpoloyee_deleteBtn
            // 
            this.addEmpoloyee_deleteBtn.Location = new System.Drawing.Point(285, 473);
            this.addEmpoloyee_deleteBtn.Name = "addEmpoloyee_deleteBtn";
            this.addEmpoloyee_deleteBtn.Size = new System.Drawing.Size(100, 30);
            this.addEmpoloyee_deleteBtn.TabIndex = 16;
            this.addEmpoloyee_deleteBtn.Text = "Detele";
            this.addEmpoloyee_deleteBtn.UseVisualStyleBackColor = true;
            this.addEmpoloyee_deleteBtn.Click += new System.EventHandler(this.addEmpoloyee_deleteBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status:";
            // 
            // addEmpoloyee_status
            // 
            this.addEmpoloyee_status.FormattingEnabled = true;
            this.addEmpoloyee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addEmpoloyee_status.Location = new System.Drawing.Point(410, 373);
            this.addEmpoloyee_status.Name = "addEmpoloyee_status";
            this.addEmpoloyee_status.Size = new System.Drawing.Size(167, 21);
            this.addEmpoloyee_status.TabIndex = 18;
            this.addEmpoloyee_status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addEmpoloyee_status);
            this.Controls.Add(this.addEmpoloyee_clearBtn);
            this.Controls.Add(this.addEmpoloyee_deleteBtn);
            this.Controls.Add(this.addEmpoloyee_updateBtn);
            this.Controls.Add(this.addEmpoloyee_addBtn);
            this.Controls.Add(this.addEmpoloyee_importBtn);
            this.Controls.Add(this.addEmpoloyee_picture);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addEmpoloyee_position);
            this.Controls.Add(this.addEmpoloyee_phoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addEmpoloyee_gender);
            this.Controls.Add(this.addEmpoloyee_fullName);
            this.Controls.Add(this.addEmpoloyee_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(875, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmpoloyee_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox addEmpoloyee_id;
        private System.Windows.Forms.TextBox addEmpoloyee_fullName;
        private System.Windows.Forms.ComboBox addEmpoloyee_gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addEmpoloyee_position;
        private System.Windows.Forms.TextBox addEmpoloyee_phoneNumber;
        private System.Windows.Forms.PictureBox addEmpoloyee_picture;
        private System.Windows.Forms.Button addEmpoloyee_importBtn;
        private System.Windows.Forms.Button addEmpoloyee_addBtn;
        private System.Windows.Forms.Button addEmpoloyee_updateBtn;
        private System.Windows.Forms.Button addEmpoloyee_clearBtn;
        private System.Windows.Forms.Button addEmpoloyee_deleteBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addEmpoloyee_status;
    }
}
