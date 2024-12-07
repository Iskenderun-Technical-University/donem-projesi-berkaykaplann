namespace WindowsFormsApp1
{
    partial class FormGiris
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.buttonHastaGiris = new System.Windows.Forms.Button();
            this.buttonDoktorGiris = new System.Windows.Forms.Button();
            this.buttonSekreterGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHastaGiris
            // 
            this.buttonHastaGiris.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonHastaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHastaGiris.BackgroundImage")));
            this.buttonHastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHastaGiris.Location = new System.Drawing.Point(85, 265);
            this.buttonHastaGiris.Name = "buttonHastaGiris";
            this.buttonHastaGiris.Size = new System.Drawing.Size(264, 179);
            this.buttonHastaGiris.TabIndex = 0;
            this.buttonHastaGiris.UseVisualStyleBackColor = false;
            this.buttonHastaGiris.Click += new System.EventHandler(this.buttonHastaGiris_Click);
            // 
            // buttonDoktorGiris
            // 
            this.buttonDoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDoktorGiris.BackgroundImage")));
            this.buttonDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDoktorGiris.Location = new System.Drawing.Point(451, 265);
            this.buttonDoktorGiris.Name = "buttonDoktorGiris";
            this.buttonDoktorGiris.Size = new System.Drawing.Size(264, 179);
            this.buttonDoktorGiris.TabIndex = 1;
            this.buttonDoktorGiris.UseVisualStyleBackColor = true;
            this.buttonDoktorGiris.Click += new System.EventHandler(this.buttonDoktorGiris_Click);
            // 
            // buttonSekreterGiris
            // 
            this.buttonSekreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSekreterGiris.BackgroundImage")));
            this.buttonSekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSekreterGiris.Location = new System.Drawing.Point(802, 265);
            this.buttonSekreterGiris.Name = "buttonSekreterGiris";
            this.buttonSekreterGiris.Size = new System.Drawing.Size(264, 179);
            this.buttonSekreterGiris.TabIndex = 2;
            this.buttonSekreterGiris.UseVisualStyleBackColor = true;
            this.buttonSekreterGiris.Click += new System.EventHandler(this.buttonSekreterGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(189, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 106);
            this.label1.TabIndex = 5;
            this.label1.Text = "İSKENDERUN HASTANESİ RANDEVU\r\n       SİSTEMİNE HOŞGELDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(134, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "HASTA GİRİŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(496, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "DOKTOR GİRİŞ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(835, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "SEKRETER GİRİŞ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(532, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ana Sayfa";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1148, 649);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSekreterGiris);
            this.Controls.Add(this.buttonDoktorGiris);
            this.Controls.Add(this.buttonHastaGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İskenderun Hastanesi Giris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGiris_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHastaGiris;
        private System.Windows.Forms.Button buttonDoktorGiris;
        private System.Windows.Forms.Button buttonSekreterGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

