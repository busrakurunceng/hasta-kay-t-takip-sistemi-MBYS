namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_IlacaGoreReceteListeleme
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
            this.hasta_kontrol_groupbox = new System.Windows.Forms.GroupBox();
            this.ilac_adi_lbl = new System.Windows.Forms.Label();
            this.ilac_adi_txtbox = new System.Windows.Forms.TextBox();
            this.recete_listele_btn1 = new System.Windows.Forms.Button();
            this.recete_kontrol_dataGridView = new System.Windows.Forms.DataGridView();
            this.recete_bul_lbl1 = new System.Windows.Forms.Label();
            this.hasta_kontrol_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recete_kontrol_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hasta_kontrol_groupbox
            // 
            this.hasta_kontrol_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hasta_kontrol_groupbox.Controls.Add(this.ilac_adi_lbl);
            this.hasta_kontrol_groupbox.Controls.Add(this.ilac_adi_txtbox);
            this.hasta_kontrol_groupbox.Controls.Add(this.recete_listele_btn1);
            this.hasta_kontrol_groupbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_kontrol_groupbox.Location = new System.Drawing.Point(60, 111);
            this.hasta_kontrol_groupbox.Name = "hasta_kontrol_groupbox";
            this.hasta_kontrol_groupbox.Size = new System.Drawing.Size(612, 153);
            this.hasta_kontrol_groupbox.TabIndex = 39;
            this.hasta_kontrol_groupbox.TabStop = false;
            this.hasta_kontrol_groupbox.Text = "İlacın Barkod Numarasını Giriniz";
            // 
            // ilac_adi_lbl
            // 
            this.ilac_adi_lbl.AutoSize = true;
            this.ilac_adi_lbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_adi_lbl.Location = new System.Drawing.Point(46, 48);
            this.ilac_adi_lbl.Name = "ilac_adi_lbl";
            this.ilac_adi_lbl.Size = new System.Drawing.Size(118, 22);
            this.ilac_adi_lbl.TabIndex = 15;
            this.ilac_adi_lbl.Text = "İlaç Adı:";
            // 
            // ilac_adi_txtbox
            // 
            this.ilac_adi_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_adi_txtbox.Location = new System.Drawing.Point(269, 46);
            this.ilac_adi_txtbox.Name = "ilac_adi_txtbox";
            this.ilac_adi_txtbox.Size = new System.Drawing.Size(150, 24);
            this.ilac_adi_txtbox.TabIndex = 16;
            // 
            // recete_listele_btn1
            // 
            this.recete_listele_btn1.BackColor = System.Drawing.Color.White;
            this.recete_listele_btn1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recete_listele_btn1.Location = new System.Drawing.Point(420, 84);
            this.recete_listele_btn1.Name = "recete_listele_btn1";
            this.recete_listele_btn1.Size = new System.Drawing.Size(163, 63);
            this.recete_listele_btn1.TabIndex = 24;
            this.recete_listele_btn1.Text = "REÇETE LİSTELE";
            this.recete_listele_btn1.UseVisualStyleBackColor = false;
            this.recete_listele_btn1.Click += new System.EventHandler(this.recete_listele_btn1_Click);
            // 
            // recete_kontrol_dataGridView
            // 
            this.recete_kontrol_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recete_kontrol_dataGridView.Location = new System.Drawing.Point(32, 285);
            this.recete_kontrol_dataGridView.Name = "recete_kontrol_dataGridView";
            this.recete_kontrol_dataGridView.RowHeadersWidth = 51;
            this.recete_kontrol_dataGridView.RowTemplate.Height = 24;
            this.recete_kontrol_dataGridView.Size = new System.Drawing.Size(685, 312);
            this.recete_kontrol_dataGridView.TabIndex = 38;
            // 
            // recete_bul_lbl1
            // 
            this.recete_bul_lbl1.AutoSize = true;
            this.recete_bul_lbl1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recete_bul_lbl1.Location = new System.Drawing.Point(54, 39);
            this.recete_bul_lbl1.Name = "recete_bul_lbl1";
            this.recete_bul_lbl1.Size = new System.Drawing.Size(598, 33);
            this.recete_bul_lbl1.TabIndex = 37;
            this.recete_bul_lbl1.Text = "Seçilen İlaca Göre Yazılmış Tüm Reçeteleri Görüntüle";
            // 
            // frm_IlacaGoreReceteListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 653);
            this.Controls.Add(this.hasta_kontrol_groupbox);
            this.Controls.Add(this.recete_kontrol_dataGridView);
            this.Controls.Add(this.recete_bul_lbl1);
            this.Name = "frm_IlacaGoreReceteListeleme";
            this.Text = "frm_IlacaGoreReceteListeleme";
            this.hasta_kontrol_groupbox.ResumeLayout(false);
            this.hasta_kontrol_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recete_kontrol_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hasta_kontrol_groupbox;
        private System.Windows.Forms.Label ilac_adi_lbl;
        private System.Windows.Forms.TextBox ilac_adi_txtbox;
        private System.Windows.Forms.Button recete_listele_btn1;
        private System.Windows.Forms.DataGridView recete_kontrol_dataGridView;
        private System.Windows.Forms.Label recete_bul_lbl1;
    }
}