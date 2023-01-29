namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_DoktoraGoreReceteListeleme
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
            this.ilac_bul_lbl1 = new System.Windows.Forms.Label();
            this.recete_kontrol_btn1 = new System.Windows.Forms.Button();
            this.recete_kontrol_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doktor_adi_groupbox = new System.Windows.Forms.GroupBox();
            this.doktor_adi_lbl = new System.Windows.Forms.Label();
            this.doktor_adi_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.recete_kontrol_dataGridView1)).BeginInit();
            this.doktor_adi_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilac_bul_lbl1
            // 
            this.ilac_bul_lbl1.AutoSize = true;
            this.ilac_bul_lbl1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_bul_lbl1.Location = new System.Drawing.Point(119, 20);
            this.ilac_bul_lbl1.Name = "ilac_bul_lbl1";
            this.ilac_bul_lbl1.Size = new System.Drawing.Size(481, 38);
            this.ilac_bul_lbl1.TabIndex = 30;
            this.ilac_bul_lbl1.Text = "Yazdığınız Tüm Reçeteleri Görüntüle";
            // 
            // recete_kontrol_btn1
            // 
            this.recete_kontrol_btn1.BackColor = System.Drawing.Color.White;
            this.recete_kontrol_btn1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recete_kontrol_btn1.Location = new System.Drawing.Point(443, 85);
            this.recete_kontrol_btn1.Name = "recete_kontrol_btn1";
            this.recete_kontrol_btn1.Size = new System.Drawing.Size(163, 62);
            this.recete_kontrol_btn1.TabIndex = 31;
            this.recete_kontrol_btn1.Text = "REÇETE LİSTELE";
            this.recete_kontrol_btn1.UseVisualStyleBackColor = false;
            this.recete_kontrol_btn1.Click += new System.EventHandler(this.recete_kontrol_btn1_Click);
            // 
            // recete_kontrol_dataGridView1
            // 
            this.recete_kontrol_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recete_kontrol_dataGridView1.Location = new System.Drawing.Point(33, 305);
            this.recete_kontrol_dataGridView1.Name = "recete_kontrol_dataGridView1";
            this.recete_kontrol_dataGridView1.RowHeadersWidth = 51;
            this.recete_kontrol_dataGridView1.RowTemplate.Height = 24;
            this.recete_kontrol_dataGridView1.Size = new System.Drawing.Size(685, 312);
            this.recete_kontrol_dataGridView1.TabIndex = 32;
            // 
            // doktor_adi_groupbox
            // 
            this.doktor_adi_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.doktor_adi_groupbox.Controls.Add(this.doktor_adi_lbl);
            this.doktor_adi_groupbox.Controls.Add(this.doktor_adi_txtbox);
            this.doktor_adi_groupbox.Controls.Add(this.recete_kontrol_btn1);
            this.doktor_adi_groupbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_adi_groupbox.Location = new System.Drawing.Point(66, 103);
            this.doktor_adi_groupbox.Name = "doktor_adi_groupbox";
            this.doktor_adi_groupbox.Size = new System.Drawing.Size(612, 153);
            this.doktor_adi_groupbox.TabIndex = 34;
            this.doktor_adi_groupbox.TabStop = false;
            this.doktor_adi_groupbox.Text = "Lütfen İsminizi Girin";
            // 
            // doktor_adi_lbl
            // 
            this.doktor_adi_lbl.AutoSize = true;
            this.doktor_adi_lbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_adi_lbl.Location = new System.Drawing.Point(60, 48);
            this.doktor_adi_lbl.Name = "doktor_adi_lbl";
            this.doktor_adi_lbl.Size = new System.Drawing.Size(142, 22);
            this.doktor_adi_lbl.TabIndex = 15;
            this.doktor_adi_lbl.Text = "Doktor Adı:";
            // 
            // doktor_adi_txtbox
            // 
            this.doktor_adi_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktor_adi_txtbox.Location = new System.Drawing.Point(232, 46);
            this.doktor_adi_txtbox.Name = "doktor_adi_txtbox";
            this.doktor_adi_txtbox.Size = new System.Drawing.Size(150, 24);
            this.doktor_adi_txtbox.TabIndex = 16;
            // 
            // frm_DoktoraGoreReceteListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(750, 653);
            this.Controls.Add(this.doktor_adi_groupbox);
            this.Controls.Add(this.recete_kontrol_dataGridView1);
            this.Controls.Add(this.ilac_bul_lbl1);
            this.Name = "frm_DoktoraGoreReceteListeleme";
            this.Text = "DOKTORA GÖRE REÇETE BUL";
            ((System.ComponentModel.ISupportInitialize)(this.recete_kontrol_dataGridView1)).EndInit();
            this.doktor_adi_groupbox.ResumeLayout(false);
            this.doktor_adi_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ilac_bul_lbl1;
        private System.Windows.Forms.Button recete_kontrol_btn1;
        private System.Windows.Forms.DataGridView recete_kontrol_dataGridView1;
        private System.Windows.Forms.GroupBox doktor_adi_groupbox;
        private System.Windows.Forms.Label doktor_adi_lbl;
        private System.Windows.Forms.TextBox doktor_adi_txtbox;
    }
}