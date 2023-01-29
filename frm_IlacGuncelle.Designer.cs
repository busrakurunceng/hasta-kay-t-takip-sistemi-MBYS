namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_IlacGuncelle
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
            this.ilac_guncelle_dataGridView = new System.Windows.Forms.DataGridView();
            this.ilac_kontrol_groupbox = new System.Windows.Forms.GroupBox();
            this.barkodNo_lbl = new System.Windows.Forms.Label();
            this.guncellenecek_barkodNo_txtbox = new System.Windows.Forms.TextBox();
            this.ilac_kontrol_btn = new System.Windows.Forms.Button();
            this.ilac_ekle_groupbox = new System.Windows.Forms.GroupBox();
            this.ilac_tipi_textbox = new System.Windows.Forms.TextBox();
            this.ilac_tipi_lbl = new System.Windows.Forms.Label();
            this.ilac_ad_lbl = new System.Windows.Forms.Label();
            this.ilac_ad_textbox = new System.Windows.Forms.TextBox();
            this.ilac_barkod_no__lbl = new System.Windows.Forms.Label();
            this.ilac_barkod_no_txtbox = new System.Windows.Forms.TextBox();
            this.ilac_guncelle_btn = new System.Windows.Forms.Button();
            this.sekreter_secenek_lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ilac_guncelle_dataGridView)).BeginInit();
            this.ilac_kontrol_groupbox.SuspendLayout();
            this.ilac_ekle_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilac_guncelle_dataGridView
            // 
            this.ilac_guncelle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilac_guncelle_dataGridView.Location = new System.Drawing.Point(25, 289);
            this.ilac_guncelle_dataGridView.Name = "ilac_guncelle_dataGridView";
            this.ilac_guncelle_dataGridView.RowHeadersWidth = 51;
            this.ilac_guncelle_dataGridView.RowTemplate.Height = 24;
            this.ilac_guncelle_dataGridView.Size = new System.Drawing.Size(685, 152);
            this.ilac_guncelle_dataGridView.TabIndex = 32;
            // 
            // ilac_kontrol_groupbox
            // 
            this.ilac_kontrol_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ilac_kontrol_groupbox.Controls.Add(this.barkodNo_lbl);
            this.ilac_kontrol_groupbox.Controls.Add(this.guncellenecek_barkodNo_txtbox);
            this.ilac_kontrol_groupbox.Controls.Add(this.ilac_kontrol_btn);
            this.ilac_kontrol_groupbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_kontrol_groupbox.Location = new System.Drawing.Point(61, 98);
            this.ilac_kontrol_groupbox.Name = "ilac_kontrol_groupbox";
            this.ilac_kontrol_groupbox.Size = new System.Drawing.Size(612, 153);
            this.ilac_kontrol_groupbox.TabIndex = 33;
            this.ilac_kontrol_groupbox.TabStop = false;
            this.ilac_kontrol_groupbox.Text = "İlaç Kaydı Bul";
            // 
            // barkodNo_lbl
            // 
            this.barkodNo_lbl.AutoSize = true;
            this.barkodNo_lbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodNo_lbl.Location = new System.Drawing.Point(60, 48);
            this.barkodNo_lbl.Name = "barkodNo_lbl";
            this.barkodNo_lbl.Size = new System.Drawing.Size(130, 22);
            this.barkodNo_lbl.TabIndex = 15;
            this.barkodNo_lbl.Text = "Barkod No:";
            // 
            // guncellenecek_barkodNo_txtbox
            // 
            this.guncellenecek_barkodNo_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellenecek_barkodNo_txtbox.Location = new System.Drawing.Point(232, 46);
            this.guncellenecek_barkodNo_txtbox.Name = "guncellenecek_barkodNo_txtbox";
            this.guncellenecek_barkodNo_txtbox.Size = new System.Drawing.Size(150, 24);
            this.guncellenecek_barkodNo_txtbox.TabIndex = 16;
            // 
            // ilac_kontrol_btn
            // 
            this.ilac_kontrol_btn.BackColor = System.Drawing.Color.White;
            this.ilac_kontrol_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_kontrol_btn.Location = new System.Drawing.Point(402, 84);
            this.ilac_kontrol_btn.Name = "ilac_kontrol_btn";
            this.ilac_kontrol_btn.Size = new System.Drawing.Size(163, 40);
            this.ilac_kontrol_btn.TabIndex = 24;
            this.ilac_kontrol_btn.Text = "İLAÇ BUL";
            this.ilac_kontrol_btn.UseVisualStyleBackColor = false;
            this.ilac_kontrol_btn.Click += new System.EventHandler(this.ilac_kontrol_btn_Click);
            // 
            // ilac_ekle_groupbox
            // 
            this.ilac_ekle_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ilac_ekle_groupbox.Controls.Add(this.ilac_tipi_textbox);
            this.ilac_ekle_groupbox.Controls.Add(this.ilac_tipi_lbl);
            this.ilac_ekle_groupbox.Controls.Add(this.ilac_ad_lbl);
            this.ilac_ekle_groupbox.Controls.Add(this.ilac_ad_textbox);
            this.ilac_ekle_groupbox.Controls.Add(this.ilac_barkod_no__lbl);
            this.ilac_ekle_groupbox.Controls.Add(this.ilac_barkod_no_txtbox);
            this.ilac_ekle_groupbox.Controls.Add(this.ilac_guncelle_btn);
            this.ilac_ekle_groupbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_ekle_groupbox.Location = new System.Drawing.Point(61, 463);
            this.ilac_ekle_groupbox.Name = "ilac_ekle_groupbox";
            this.ilac_ekle_groupbox.Size = new System.Drawing.Size(612, 225);
            this.ilac_ekle_groupbox.TabIndex = 34;
            this.ilac_ekle_groupbox.TabStop = false;
            this.ilac_ekle_groupbox.Text = "İlaç Kaydı Ekle";
            // 
            // ilac_tipi_textbox
            // 
            this.ilac_tipi_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_tipi_textbox.Location = new System.Drawing.Point(166, 149);
            this.ilac_tipi_textbox.Name = "ilac_tipi_textbox";
            this.ilac_tipi_textbox.Size = new System.Drawing.Size(150, 24);
            this.ilac_tipi_textbox.TabIndex = 28;
            // 
            // ilac_tipi_lbl
            // 
            this.ilac_tipi_lbl.AutoSize = true;
            this.ilac_tipi_lbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_tipi_lbl.Location = new System.Drawing.Point(18, 151);
            this.ilac_tipi_lbl.Name = "ilac_tipi_lbl";
            this.ilac_tipi_lbl.Size = new System.Drawing.Size(130, 22);
            this.ilac_tipi_lbl.TabIndex = 27;
            this.ilac_tipi_lbl.Text = "İlaç Tipi:";
            // 
            // ilac_ad_lbl
            // 
            this.ilac_ad_lbl.AutoSize = true;
            this.ilac_ad_lbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_ad_lbl.Location = new System.Drawing.Point(18, 100);
            this.ilac_ad_lbl.Name = "ilac_ad_lbl";
            this.ilac_ad_lbl.Size = new System.Drawing.Size(118, 22);
            this.ilac_ad_lbl.TabIndex = 25;
            this.ilac_ad_lbl.Text = "İlaç Adı:";
            // 
            // ilac_ad_textbox
            // 
            this.ilac_ad_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_ad_textbox.Location = new System.Drawing.Point(166, 100);
            this.ilac_ad_textbox.Name = "ilac_ad_textbox";
            this.ilac_ad_textbox.Size = new System.Drawing.Size(150, 24);
            this.ilac_ad_textbox.TabIndex = 26;
            // 
            // ilac_barkod_no__lbl
            // 
            this.ilac_barkod_no__lbl.AutoSize = true;
            this.ilac_barkod_no__lbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_barkod_no__lbl.Location = new System.Drawing.Point(18, 46);
            this.ilac_barkod_no__lbl.Name = "ilac_barkod_no__lbl";
            this.ilac_barkod_no__lbl.Size = new System.Drawing.Size(130, 22);
            this.ilac_barkod_no__lbl.TabIndex = 15;
            this.ilac_barkod_no__lbl.Text = "Barkod No:";
            // 
            // ilac_barkod_no_txtbox
            // 
            this.ilac_barkod_no_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_barkod_no_txtbox.Location = new System.Drawing.Point(166, 46);
            this.ilac_barkod_no_txtbox.Name = "ilac_barkod_no_txtbox";
            this.ilac_barkod_no_txtbox.Size = new System.Drawing.Size(150, 24);
            this.ilac_barkod_no_txtbox.TabIndex = 16;
            // 
            // ilac_guncelle_btn
            // 
            this.ilac_guncelle_btn.BackColor = System.Drawing.Color.White;
            this.ilac_guncelle_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_guncelle_btn.Location = new System.Drawing.Point(421, 163);
            this.ilac_guncelle_btn.Name = "ilac_guncelle_btn";
            this.ilac_guncelle_btn.Size = new System.Drawing.Size(163, 56);
            this.ilac_guncelle_btn.TabIndex = 24;
            this.ilac_guncelle_btn.Text = "İLAÇ GÜNCELLE";
            this.ilac_guncelle_btn.UseVisualStyleBackColor = false;
            this.ilac_guncelle_btn.Click += new System.EventHandler(this.ilac_guncelle_btn_Click);
            // 
            // sekreter_secenek_lbl1
            // 
            this.sekreter_secenek_lbl1.AutoSize = true;
            this.sekreter_secenek_lbl1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekreter_secenek_lbl1.Location = new System.Drawing.Point(55, 31);
            this.sekreter_secenek_lbl1.Name = "sekreter_secenek_lbl1";
            this.sekreter_secenek_lbl1.Size = new System.Drawing.Size(629, 33);
            this.sekreter_secenek_lbl1.TabIndex = 25;
            this.sekreter_secenek_lbl1.Text = "Lütfen Güncellemek İstediğiniz İlacın Bilgilerini Giriniz";
            // 
            // frm_IlacGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 737);
            this.Controls.Add(this.sekreter_secenek_lbl1);
            this.Controls.Add(this.ilac_ekle_groupbox);
            this.Controls.Add(this.ilac_guncelle_dataGridView);
            this.Controls.Add(this.ilac_kontrol_groupbox);
            this.Name = "frm_IlacGuncelle";
            this.Text = "frm_IlacGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.ilac_guncelle_dataGridView)).EndInit();
            this.ilac_kontrol_groupbox.ResumeLayout(false);
            this.ilac_kontrol_groupbox.PerformLayout();
            this.ilac_ekle_groupbox.ResumeLayout(false);
            this.ilac_ekle_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ilac_guncelle_dataGridView;
        private System.Windows.Forms.GroupBox ilac_kontrol_groupbox;
        private System.Windows.Forms.Label barkodNo_lbl;
        private System.Windows.Forms.TextBox guncellenecek_barkodNo_txtbox;
        private System.Windows.Forms.Button ilac_kontrol_btn;
        private System.Windows.Forms.GroupBox ilac_ekle_groupbox;
        private System.Windows.Forms.TextBox ilac_tipi_textbox;
        private System.Windows.Forms.Label ilac_tipi_lbl;
        private System.Windows.Forms.Label ilac_ad_lbl;
        private System.Windows.Forms.TextBox ilac_ad_textbox;
        private System.Windows.Forms.Label ilac_barkod_no__lbl;
        private System.Windows.Forms.TextBox ilac_barkod_no_txtbox;
        private System.Windows.Forms.Button ilac_guncelle_btn;
        private System.Windows.Forms.Label sekreter_secenek_lbl1;
    }
}