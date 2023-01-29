namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_IlacEkle
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
            this.sekreter_secenek_lbl1 = new System.Windows.Forms.Label();
            this.ilac_ekle_groupbox = new System.Windows.Forms.GroupBox();
            this.ilac_tipi_textbox = new System.Windows.Forms.TextBox();
            this.ilac_tipi_lbl = new System.Windows.Forms.Label();
            this.ilac_ad_lbl = new System.Windows.Forms.Label();
            this.ilac_ad_textbox = new System.Windows.Forms.TextBox();
            this.ilac_barkod_no__lbl = new System.Windows.Forms.Label();
            this.ilac_barkod_no_txtbox = new System.Windows.Forms.TextBox();
            this.ilac_ekle_btn = new System.Windows.Forms.Button();
            this.ilac_ekle_dataGridView = new System.Windows.Forms.DataGridView();
            this.ilac_ekle_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilac_ekle_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sekreter_secenek_lbl1
            // 
            this.sekreter_secenek_lbl1.AutoSize = true;
            this.sekreter_secenek_lbl1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekreter_secenek_lbl1.Location = new System.Drawing.Point(152, 44);
            this.sekreter_secenek_lbl1.Name = "sekreter_secenek_lbl1";
            this.sekreter_secenek_lbl1.Size = new System.Drawing.Size(423, 38);
            this.sekreter_secenek_lbl1.TabIndex = 23;
            this.sekreter_secenek_lbl1.Text = "Lütfen İlacın Bilgilerini Giriniz";
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
            this.ilac_ekle_groupbox.Controls.Add(this.ilac_ekle_btn);
            this.ilac_ekle_groupbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_ekle_groupbox.Location = new System.Drawing.Point(65, 123);
            this.ilac_ekle_groupbox.Name = "ilac_ekle_groupbox";
            this.ilac_ekle_groupbox.Size = new System.Drawing.Size(612, 225);
            this.ilac_ekle_groupbox.TabIndex = 28;
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
            // ilac_ekle_btn
            // 
            this.ilac_ekle_btn.BackColor = System.Drawing.Color.White;
            this.ilac_ekle_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_ekle_btn.Location = new System.Drawing.Point(422, 169);
            this.ilac_ekle_btn.Name = "ilac_ekle_btn";
            this.ilac_ekle_btn.Size = new System.Drawing.Size(163, 40);
            this.ilac_ekle_btn.TabIndex = 24;
            this.ilac_ekle_btn.Text = "İLAÇ EKLE";
            this.ilac_ekle_btn.UseVisualStyleBackColor = false;
            this.ilac_ekle_btn.Click += new System.EventHandler(this.ilac_ekle_btn_Click);
            // 
            // ilac_ekle_dataGridView
            // 
            this.ilac_ekle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilac_ekle_dataGridView.Location = new System.Drawing.Point(29, 379);
            this.ilac_ekle_dataGridView.Name = "ilac_ekle_dataGridView";
            this.ilac_ekle_dataGridView.RowHeadersWidth = 51;
            this.ilac_ekle_dataGridView.RowTemplate.Height = 24;
            this.ilac_ekle_dataGridView.Size = new System.Drawing.Size(685, 262);
            this.ilac_ekle_dataGridView.TabIndex = 29;
            // 
            // frm_IlacEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 653);
            this.Controls.Add(this.ilac_ekle_dataGridView);
            this.Controls.Add(this.ilac_ekle_groupbox);
            this.Controls.Add(this.sekreter_secenek_lbl1);
            this.Name = "frm_IlacEkle";
            this.Text = "İLAÇ EKLE";
            this.ilac_ekle_groupbox.ResumeLayout(false);
            this.ilac_ekle_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilac_ekle_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sekreter_secenek_lbl1;
        private System.Windows.Forms.GroupBox ilac_ekle_groupbox;
        private System.Windows.Forms.Label ilac_barkod_no__lbl;
        private System.Windows.Forms.TextBox ilac_barkod_no_txtbox;
        private System.Windows.Forms.Button ilac_ekle_btn;
        private System.Windows.Forms.Label ilac_ad_lbl;
        private System.Windows.Forms.TextBox ilac_ad_textbox;
        private System.Windows.Forms.Label ilac_tipi_lbl;
        private System.Windows.Forms.TextBox ilac_tipi_textbox;
        private System.Windows.Forms.DataGridView ilac_ekle_dataGridView;
    }
}