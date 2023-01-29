namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_DoktorGiris
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
            this.doktor_giris_yap_btn = new System.Windows.Forms.Button();
            this.sekreter_giris_lbl = new System.Windows.Forms.Label();
            this.doktor_sifre_textbox = new System.Windows.Forms.TextBox();
            this.doktor_ad_textbox = new System.Windows.Forms.TextBox();
            this.doktor_sifre_lbl = new System.Windows.Forms.Label();
            this.doktor_ad_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doktor_giris_yap_btn
            // 
            this.doktor_giris_yap_btn.BackColor = System.Drawing.Color.White;
            this.doktor_giris_yap_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_giris_yap_btn.ForeColor = System.Drawing.Color.Crimson;
            this.doktor_giris_yap_btn.Location = new System.Drawing.Point(324, 331);
            this.doktor_giris_yap_btn.Name = "doktor_giris_yap_btn";
            this.doktor_giris_yap_btn.Size = new System.Drawing.Size(121, 75);
            this.doktor_giris_yap_btn.TabIndex = 11;
            this.doktor_giris_yap_btn.Text = "GİRİŞ YAP";
            this.doktor_giris_yap_btn.UseVisualStyleBackColor = false;
            this.doktor_giris_yap_btn.Click += new System.EventHandler(this.doktor_giris_yap_btn_Click);
            // 
            // sekreter_giris_lbl
            // 
            this.sekreter_giris_lbl.AutoSize = true;
            this.sekreter_giris_lbl.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekreter_giris_lbl.ForeColor = System.Drawing.Color.Maroon;
            this.sekreter_giris_lbl.Location = new System.Drawing.Point(84, 62);
            this.sekreter_giris_lbl.Name = "sekreter_giris_lbl";
            this.sekreter_giris_lbl.Size = new System.Drawing.Size(326, 44);
            this.sekreter_giris_lbl.TabIndex = 10;
            this.sekreter_giris_lbl.Text = "Lütfen Giriş Yapınız";
            // 
            // doktor_sifre_textbox
            // 
            this.doktor_sifre_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_sifre_textbox.Location = new System.Drawing.Point(239, 251);
            this.doktor_sifre_textbox.Name = "doktor_sifre_textbox";
            this.doktor_sifre_textbox.Size = new System.Drawing.Size(206, 34);
            this.doktor_sifre_textbox.TabIndex = 9;
            // 
            // doktor_ad_textbox
            // 
            this.doktor_ad_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_ad_textbox.Location = new System.Drawing.Point(239, 183);
            this.doktor_ad_textbox.Name = "doktor_ad_textbox";
            this.doktor_ad_textbox.Size = new System.Drawing.Size(206, 34);
            this.doktor_ad_textbox.TabIndex = 8;
            // 
            // doktor_sifre_lbl
            // 
            this.doktor_sifre_lbl.AutoSize = true;
            this.doktor_sifre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_sifre_lbl.Location = new System.Drawing.Point(28, 254);
            this.doktor_sifre_lbl.Name = "doktor_sifre_lbl";
            this.doktor_sifre_lbl.Size = new System.Drawing.Size(146, 29);
            this.doktor_sifre_lbl.TabIndex = 7;
            this.doktor_sifre_lbl.Text = "Doktor Şifre:";
            // 
            // doktor_ad_lbl
            // 
            this.doktor_ad_lbl.AutoSize = true;
            this.doktor_ad_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_ad_lbl.Location = new System.Drawing.Point(28, 186);
            this.doktor_ad_lbl.Name = "doktor_ad_lbl";
            this.doktor_ad_lbl.Size = new System.Drawing.Size(125, 29);
            this.doktor_ad_lbl.TabIndex = 6;
            this.doktor_ad_lbl.Text = "Doktor Ad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Muayene_Bilgi_Yönetimi.Properties.Resources.sağlıkBakanlığı;
            this.pictureBox1.Location = new System.Drawing.Point(12, 374);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frm_DoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(492, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.doktor_giris_yap_btn);
            this.Controls.Add(this.sekreter_giris_lbl);
            this.Controls.Add(this.doktor_sifre_textbox);
            this.Controls.Add(this.doktor_ad_textbox);
            this.Controls.Add(this.doktor_sifre_lbl);
            this.Controls.Add(this.doktor_ad_lbl);
            this.Name = "frm_DoktorGiris";
            this.Text = "DOKTOR GİRİŞ EKRANI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doktor_giris_yap_btn;
        private System.Windows.Forms.Label sekreter_giris_lbl;
        private System.Windows.Forms.TextBox doktor_sifre_textbox;
        private System.Windows.Forms.TextBox doktor_ad_textbox;
        private System.Windows.Forms.Label doktor_sifre_lbl;
        private System.Windows.Forms.Label doktor_ad_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}