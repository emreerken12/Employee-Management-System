namespace WindowsFormsApp1
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IE = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.TE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IE);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AE);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(20, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 149);
            this.panel1.TabIndex = 0;
          
            // 
            // TE
            // 
            this.TE.AutoSize = true;
            this.TE.Location = new System.Drawing.Point(26, 67);
            this.TE.Name = "TE";
            this.TE.Size = new System.Drawing.Size(13, 13);
            this.TE.TabIndex = 4;
            this.TE.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Employees";
            // 
            // IE
            // 
            this.IE.AutoSize = true;
            this.IE.Location = new System.Drawing.Point(596, 67);
            this.IE.Name = "IE";
            this.IE.Size = new System.Drawing.Size(13, 13);
            this.IE.TabIndex = 3;
            this.IE.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Inactive Employees";
            // 
            // AE
            // 
            this.AE.AutoSize = true;
            this.AE.Location = new System.Drawing.Point(247, 67);
            this.AE.Name = "AE";
            this.AE.Size = new System.Drawing.Size(13, 13);
            this.AE.TabIndex = 0;
            this.AE.Text = "0";
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Active Employees";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(20, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 344);
            this.panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AE;
        private System.Windows.Forms.Label TE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IE;
        private System.Windows.Forms.Label label5;
    }
}
