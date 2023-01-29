namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_mbys_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mbys_giris));
            this.sekreter_giris_btn = new System.Windows.Forms.Button();
            this.doktor_giris_btn = new System.Windows.Forms.Button();
            this.giris_lbl1 = new System.Windows.Forms.Label();
            this.giris_lbl2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sekreter_giris_btn
            // 
            this.sekreter_giris_btn.BackColor = System.Drawing.Color.White;
            this.sekreter_giris_btn.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold);
            this.sekreter_giris_btn.ForeColor = System.Drawing.Color.Crimson;
            this.sekreter_giris_btn.Location = new System.Drawing.Point(74, 335);
            this.sekreter_giris_btn.Name = "sekreter_giris_btn";
            this.sekreter_giris_btn.Size = new System.Drawing.Size(237, 132);
            this.sekreter_giris_btn.TabIndex = 0;
            this.sekreter_giris_btn.Text = "SEKRETER GİRİŞİ";
            this.sekreter_giris_btn.UseVisualStyleBackColor = false;
            this.sekreter_giris_btn.Click += new System.EventHandler(this.sekreter_giris_btn_Click);
            // 
            // doktor_giris_btn
            // 
            this.doktor_giris_btn.BackColor = System.Drawing.Color.White;
            this.doktor_giris_btn.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_giris_btn.ForeColor = System.Drawing.Color.Crimson;
            this.doktor_giris_btn.Location = new System.Drawing.Point(434, 335);
            this.doktor_giris_btn.Name = "doktor_giris_btn";
            this.doktor_giris_btn.Size = new System.Drawing.Size(237, 132);
            this.doktor_giris_btn.TabIndex = 1;
            this.doktor_giris_btn.Text = "DOKTOR GİRİŞİ";
            this.doktor_giris_btn.UseVisualStyleBackColor = false;
            this.doktor_giris_btn.Click += new System.EventHandler(this.doktor_giris_btn_Click);
            // 
            // giris_lbl1
            // 
            this.giris_lbl1.AutoSize = true;
            this.giris_lbl1.Font = new System.Drawing.Font("Sitka Small", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_lbl1.ForeColor = System.Drawing.Color.DarkRed;
            this.giris_lbl1.Location = new System.Drawing.Point(105, 24);
            this.giris_lbl1.Name = "giris_lbl1";
            this.giris_lbl1.Size = new System.Drawing.Size(528, 59);
            this.giris_lbl1.TabIndex = 2;
            this.giris_lbl1.Text = "MBYS\'YE HOŞGELDİNİZ";
            // 
            // giris_lbl2
            // 
            this.giris_lbl2.AutoSize = true;
            this.giris_lbl2.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_lbl2.Location = new System.Drawing.Point(126, 104);
            this.giris_lbl2.Name = "giris_lbl2";
            this.giris_lbl2.Size = new System.Drawing.Size(479, 37);
            this.giris_lbl2.TabIndex = 3;
            this.giris_lbl2.Text = "Lütfen Kullanıcı Tipinizi Seçiniz  :)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Muayene_Bilgi_Yönetimi.Properties.Resources.sağlıkBakanlığı;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frm_mbys_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(749, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.giris_lbl2);
            this.Controls.Add(this.giris_lbl1);
            this.Controls.Add(this.doktor_giris_btn);
            this.Controls.Add(this.sekreter_giris_btn);
            this.Name = "frm_mbys_giris";
            this.Text = "MBYS GİRİŞ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sekreter_giris_btn;
        private System.Windows.Forms.Button doktor_giris_btn;
        private System.Windows.Forms.Label giris_lbl1;
        private System.Windows.Forms.Label giris_lbl2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

