namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_HastaGuncelle
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
            this.hasta_guncelle_dataGridView = new System.Windows.Forms.DataGridView();
            this.hasta_guncelle_groupbox = new System.Windows.Forms.GroupBox();
            this.tcKimlikNo_lbl = new System.Windows.Forms.Label();
            this.guncellenecek_tckimlikNo_txtbox = new System.Windows.Forms.TextBox();
            this.hasta_kontrol_btn = new System.Windows.Forms.Button();
            this.hasta_guncelle_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hasta_ad_lbl = new System.Windows.Forms.Label();
            this.hasta_soyad_lbl = new System.Windows.Forms.Label();
            this.medeni_durum_textbox = new System.Windows.Forms.TextBox();
            this.dogum_yeri_lbl = new System.Windows.Forms.Label();
            this.medeni_durum_lbl = new System.Windows.Forms.Label();
            this.dogum_tarihi_lbl = new System.Windows.Forms.Label();
            this.telefon_lbl = new System.Windows.Forms.Label();
            this.dogumTarihi_datetime = new System.Windows.Forms.DateTimePicker();
            this.telefon_textbox = new System.Windows.Forms.TextBox();
            this.adres_txtbox = new System.Windows.Forms.RichTextBox();
            this.adres_lbl = new System.Windows.Forms.Label();
            this.hastaAd_txtbox = new System.Windows.Forms.TextBox();
            this.dogumYeri_txtbox = new System.Windows.Forms.TextBox();
            this.hastaSoyad_txtbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hasta_guncelle_dataGridView)).BeginInit();
            this.hasta_guncelle_groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hasta_guncelle_dataGridView
            // 
            this.hasta_guncelle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hasta_guncelle_dataGridView.Location = new System.Drawing.Point(30, 192);
            this.hasta_guncelle_dataGridView.Name = "hasta_guncelle_dataGridView";
            this.hasta_guncelle_dataGridView.RowHeadersWidth = 51;
            this.hasta_guncelle_dataGridView.RowTemplate.Height = 24;
            this.hasta_guncelle_dataGridView.Size = new System.Drawing.Size(685, 160);
            this.hasta_guncelle_dataGridView.TabIndex = 28;
            // 
            // hasta_guncelle_groupbox
            // 
            this.hasta_guncelle_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hasta_guncelle_groupbox.Controls.Add(this.tcKimlikNo_lbl);
            this.hasta_guncelle_groupbox.Controls.Add(this.guncellenecek_tckimlikNo_txtbox);
            this.hasta_guncelle_groupbox.Controls.Add(this.hasta_kontrol_btn);
            this.hasta_guncelle_groupbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_guncelle_groupbox.Location = new System.Drawing.Point(59, 23);
            this.hasta_guncelle_groupbox.Name = "hasta_guncelle_groupbox";
            this.hasta_guncelle_groupbox.Size = new System.Drawing.Size(612, 153);
            this.hasta_guncelle_groupbox.TabIndex = 31;
            this.hasta_guncelle_groupbox.TabStop = false;
            this.hasta_guncelle_groupbox.Text = "Güncellenecek Hasta";
            // 
            // tcKimlikNo_lbl
            // 
            this.tcKimlikNo_lbl.AutoSize = true;
            this.tcKimlikNo_lbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcKimlikNo_lbl.Location = new System.Drawing.Point(60, 48);
            this.tcKimlikNo_lbl.Name = "tcKimlikNo_lbl";
            this.tcKimlikNo_lbl.Size = new System.Drawing.Size(166, 22);
            this.tcKimlikNo_lbl.TabIndex = 15;
            this.tcKimlikNo_lbl.Text = "TC Kimlik No:";
            // 
            // guncellenecek_tckimlikNo_txtbox
            // 
            this.guncellenecek_tckimlikNo_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellenecek_tckimlikNo_txtbox.Location = new System.Drawing.Point(242, 46);
            this.guncellenecek_tckimlikNo_txtbox.Name = "guncellenecek_tckimlikNo_txtbox";
            this.guncellenecek_tckimlikNo_txtbox.Size = new System.Drawing.Size(150, 24);
            this.guncellenecek_tckimlikNo_txtbox.TabIndex = 16;
            // 
            // hasta_kontrol_btn
            // 
            this.hasta_kontrol_btn.BackColor = System.Drawing.Color.White;
            this.hasta_kontrol_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_kontrol_btn.Location = new System.Drawing.Point(402, 84);
            this.hasta_kontrol_btn.Name = "hasta_kontrol_btn";
            this.hasta_kontrol_btn.Size = new System.Drawing.Size(163, 40);
            this.hasta_kontrol_btn.TabIndex = 24;
            this.hasta_kontrol_btn.Text = "HASTA BUL";
            this.hasta_kontrol_btn.UseVisualStyleBackColor = false;
            this.hasta_kontrol_btn.Click += new System.EventHandler(this.hasta_kontrol_btn_Click);
            // 
            // hasta_guncelle_btn
            // 
            this.hasta_guncelle_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_guncelle_btn.Location = new System.Drawing.Point(527, 699);
            this.hasta_guncelle_btn.Name = "hasta_guncelle_btn";
            this.hasta_guncelle_btn.Size = new System.Drawing.Size(183, 63);
            this.hasta_guncelle_btn.TabIndex = 33;
            this.hasta_guncelle_btn.Text = "HASTA GÜNCELLE";
            this.hasta_guncelle_btn.UseVisualStyleBackColor = true;
            this.hasta_guncelle_btn.Click += new System.EventHandler(this.hasta_guncelle_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hasta_ad_lbl);
            this.groupBox1.Controls.Add(this.hasta_soyad_lbl);
            this.groupBox1.Controls.Add(this.medeni_durum_textbox);
            this.groupBox1.Controls.Add(this.dogum_yeri_lbl);
            this.groupBox1.Controls.Add(this.medeni_durum_lbl);
            this.groupBox1.Controls.Add(this.dogum_tarihi_lbl);
            this.groupBox1.Controls.Add(this.telefon_lbl);
            this.groupBox1.Controls.Add(this.dogumTarihi_datetime);
            this.groupBox1.Controls.Add(this.telefon_textbox);
            this.groupBox1.Controls.Add(this.adres_txtbox);
            this.groupBox1.Controls.Add(this.adres_lbl);
            this.groupBox1.Controls.Add(this.hastaAd_txtbox);
            this.groupBox1.Controls.Add(this.dogumYeri_txtbox);
            this.groupBox1.Controls.Add(this.hastaSoyad_txtbox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 324);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri Ekleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // hasta_ad_lbl
            // 
            this.hasta_ad_lbl.AutoSize = true;
            this.hasta_ad_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_ad_lbl.Location = new System.Drawing.Point(16, 93);
            this.hasta_ad_lbl.Name = "hasta_ad_lbl";
            this.hasta_ad_lbl.Size = new System.Drawing.Size(42, 20);
            this.hasta_ad_lbl.TabIndex = 1;
            this.hasta_ad_lbl.Text = "Ad:";
            // 
            // hasta_soyad_lbl
            // 
            this.hasta_soyad_lbl.AutoSize = true;
            this.hasta_soyad_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_soyad_lbl.Location = new System.Drawing.Point(16, 137);
            this.hasta_soyad_lbl.Name = "hasta_soyad_lbl";
            this.hasta_soyad_lbl.Size = new System.Drawing.Size(75, 20);
            this.hasta_soyad_lbl.TabIndex = 2;
            this.hasta_soyad_lbl.Text = "Soyad:";
            // 
            // medeni_durum_textbox
            // 
            this.medeni_durum_textbox.Location = new System.Drawing.Point(548, 47);
            this.medeni_durum_textbox.Name = "medeni_durum_textbox";
            this.medeni_durum_textbox.Size = new System.Drawing.Size(150, 30);
            this.medeni_durum_textbox.TabIndex = 20;
            // 
            // dogum_yeri_lbl
            // 
            this.dogum_yeri_lbl.AutoSize = true;
            this.dogum_yeri_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogum_yeri_lbl.Location = new System.Drawing.Point(16, 183);
            this.dogum_yeri_lbl.Name = "dogum_yeri_lbl";
            this.dogum_yeri_lbl.Size = new System.Drawing.Size(130, 20);
            this.dogum_yeri_lbl.TabIndex = 3;
            this.dogum_yeri_lbl.Text = "Doğum Yeri:";
            // 
            // medeni_durum_lbl
            // 
            this.medeni_durum_lbl.AutoSize = true;
            this.medeni_durum_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.medeni_durum_lbl.Location = new System.Drawing.Point(391, 49);
            this.medeni_durum_lbl.Name = "medeni_durum_lbl";
            this.medeni_durum_lbl.Size = new System.Drawing.Size(152, 20);
            this.medeni_durum_lbl.TabIndex = 19;
            this.medeni_durum_lbl.Text = "Medeni Durum:";
            // 
            // dogum_tarihi_lbl
            // 
            this.dogum_tarihi_lbl.AutoSize = true;
            this.dogum_tarihi_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogum_tarihi_lbl.Location = new System.Drawing.Point(16, 230);
            this.dogum_tarihi_lbl.Name = "dogum_tarihi_lbl";
            this.dogum_tarihi_lbl.Size = new System.Drawing.Size(152, 20);
            this.dogum_tarihi_lbl.TabIndex = 4;
            this.dogum_tarihi_lbl.Text = "Doğum Tarihi:";
            // 
            // telefon_lbl
            // 
            this.telefon_lbl.AutoSize = true;
            this.telefon_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon_lbl.Location = new System.Drawing.Point(391, 91);
            this.telefon_lbl.Name = "telefon_lbl";
            this.telefon_lbl.Size = new System.Drawing.Size(97, 20);
            this.telefon_lbl.TabIndex = 18;
            this.telefon_lbl.Text = "Telefon:";
            // 
            // dogumTarihi_datetime
            // 
            this.dogumTarihi_datetime.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogumTarihi_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogumTarihi_datetime.Location = new System.Drawing.Point(196, 230);
            this.dogumTarihi_datetime.Name = "dogumTarihi_datetime";
            this.dogumTarihi_datetime.Size = new System.Drawing.Size(211, 22);
            this.dogumTarihi_datetime.TabIndex = 6;
            // 
            // telefon_textbox
            // 
            this.telefon_textbox.Location = new System.Drawing.Point(548, 93);
            this.telefon_textbox.Name = "telefon_textbox";
            this.telefon_textbox.Size = new System.Drawing.Size(150, 30);
            this.telefon_textbox.TabIndex = 17;
            // 
            // adres_txtbox
            // 
            this.adres_txtbox.Location = new System.Drawing.Point(472, 158);
            this.adres_txtbox.Name = "adres_txtbox";
            this.adres_txtbox.Size = new System.Drawing.Size(226, 129);
            this.adres_txtbox.TabIndex = 11;
            this.adres_txtbox.Text = "";
            // 
            // adres_lbl
            // 
            this.adres_lbl.AutoSize = true;
            this.adres_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres_lbl.Location = new System.Drawing.Point(391, 159);
            this.adres_lbl.Name = "adres_lbl";
            this.adres_lbl.Size = new System.Drawing.Size(75, 20);
            this.adres_lbl.TabIndex = 16;
            this.adres_lbl.Text = "Adres:";
            // 
            // hastaAd_txtbox
            // 
            this.hastaAd_txtbox.Location = new System.Drawing.Point(196, 93);
            this.hastaAd_txtbox.Name = "hastaAd_txtbox";
            this.hastaAd_txtbox.Size = new System.Drawing.Size(150, 30);
            this.hastaAd_txtbox.TabIndex = 12;
            // 
            // dogumYeri_txtbox
            // 
            this.dogumYeri_txtbox.Location = new System.Drawing.Point(196, 183);
            this.dogumYeri_txtbox.Name = "dogumYeri_txtbox";
            this.dogumYeri_txtbox.Size = new System.Drawing.Size(150, 30);
            this.dogumYeri_txtbox.TabIndex = 15;
            // 
            // hastaSoyad_txtbox
            // 
            this.hastaSoyad_txtbox.Location = new System.Drawing.Point(196, 137);
            this.hastaSoyad_txtbox.Name = "hastaSoyad_txtbox";
            this.hastaSoyad_txtbox.Size = new System.Drawing.Size(150, 30);
            this.hastaSoyad_txtbox.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 30);
            this.textBox1.TabIndex = 14;
            // 
            // frm_HastaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 774);
            this.Controls.Add(this.hasta_guncelle_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hasta_guncelle_dataGridView);
            this.Controls.Add(this.hasta_guncelle_groupbox);
            this.Name = "frm_HastaGuncelle";
            this.Text = "frm_HastaGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.hasta_guncelle_dataGridView)).EndInit();
            this.hasta_guncelle_groupbox.ResumeLayout(false);
            this.hasta_guncelle_groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView hasta_guncelle_dataGridView;
        private System.Windows.Forms.GroupBox hasta_guncelle_groupbox;
        private System.Windows.Forms.Label tcKimlikNo_lbl;
        private System.Windows.Forms.TextBox guncellenecek_tckimlikNo_txtbox;
        private System.Windows.Forms.Button hasta_kontrol_btn;
        private System.Windows.Forms.Button hasta_guncelle_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hasta_ad_lbl;
        private System.Windows.Forms.Label hasta_soyad_lbl;
        private System.Windows.Forms.TextBox medeni_durum_textbox;
        private System.Windows.Forms.Label dogum_yeri_lbl;
        private System.Windows.Forms.Label medeni_durum_lbl;
        private System.Windows.Forms.Label dogum_tarihi_lbl;
        private System.Windows.Forms.Label telefon_lbl;
        private System.Windows.Forms.DateTimePicker dogumTarihi_datetime;
        private System.Windows.Forms.TextBox telefon_textbox;
        private System.Windows.Forms.RichTextBox adres_txtbox;
        private System.Windows.Forms.Label adres_lbl;
        private System.Windows.Forms.TextBox hastaAd_txtbox;
        private System.Windows.Forms.TextBox dogumYeri_txtbox;
        private System.Windows.Forms.TextBox hastaSoyad_txtbox;
        private System.Windows.Forms.TextBox textBox1;
    }
}