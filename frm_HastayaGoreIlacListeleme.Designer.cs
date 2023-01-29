namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_HastayaGoreIlacListeleme
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
            this.ilac_kontrol_groupbox = new System.Windows.Forms.GroupBox();
            this.tcKimlikNo_lbl = new System.Windows.Forms.Label();
            this.tckimlikNo_txtbox = new System.Windows.Forms.TextBox();
            this.ilac_listele_btn2 = new System.Windows.Forms.Button();
            this.recete_kontrol_dataGridView = new System.Windows.Forms.DataGridView();
            this.ilac_bul_lbl2 = new System.Windows.Forms.Label();
            this.ilac_kontrol_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recete_kontrol_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ilac_kontrol_groupbox
            // 
            this.ilac_kontrol_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ilac_kontrol_groupbox.Controls.Add(this.tcKimlikNo_lbl);
            this.ilac_kontrol_groupbox.Controls.Add(this.tckimlikNo_txtbox);
            this.ilac_kontrol_groupbox.Controls.Add(this.ilac_listele_btn2);
            this.ilac_kontrol_groupbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_kontrol_groupbox.Location = new System.Drawing.Point(65, 144);
            this.ilac_kontrol_groupbox.Name = "ilac_kontrol_groupbox";
            this.ilac_kontrol_groupbox.Size = new System.Drawing.Size(612, 153);
            this.ilac_kontrol_groupbox.TabIndex = 37;
            this.ilac_kontrol_groupbox.TabStop = false;
            this.ilac_kontrol_groupbox.Text = "Hastanın TC Kimlik Numarasını Giriniz";
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
            // tckimlikNo_txtbox
            // 
            this.tckimlikNo_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tckimlikNo_txtbox.Location = new System.Drawing.Point(242, 46);
            this.tckimlikNo_txtbox.Name = "tckimlikNo_txtbox";
            this.tckimlikNo_txtbox.Size = new System.Drawing.Size(150, 24);
            this.tckimlikNo_txtbox.TabIndex = 16;
            // 
            // ilac_listele_btn2
            // 
            this.ilac_listele_btn2.BackColor = System.Drawing.Color.White;
            this.ilac_listele_btn2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_listele_btn2.Location = new System.Drawing.Point(420, 84);
            this.ilac_listele_btn2.Name = "ilac_listele_btn2";
            this.ilac_listele_btn2.Size = new System.Drawing.Size(163, 63);
            this.ilac_listele_btn2.TabIndex = 24;
            this.ilac_listele_btn2.Text = "İLAÇ LİSTELE";
            this.ilac_listele_btn2.UseVisualStyleBackColor = false;
            this.ilac_listele_btn2.Click += new System.EventHandler(this.ilac_listele_btn2_Click);
            // 
            // recete_kontrol_dataGridView
            // 
            this.recete_kontrol_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recete_kontrol_dataGridView.Location = new System.Drawing.Point(30, 316);
            this.recete_kontrol_dataGridView.Name = "recete_kontrol_dataGridView";
            this.recete_kontrol_dataGridView.RowHeadersWidth = 51;
            this.recete_kontrol_dataGridView.RowTemplate.Height = 24;
            this.recete_kontrol_dataGridView.Size = new System.Drawing.Size(685, 312);
            this.recete_kontrol_dataGridView.TabIndex = 36;
            // 
            // ilac_bul_lbl2
            // 
            this.ilac_bul_lbl2.AutoSize = true;
            this.ilac_bul_lbl2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_bul_lbl2.Location = new System.Drawing.Point(73, 55);
            this.ilac_bul_lbl2.Name = "ilac_bul_lbl2";
            this.ilac_bul_lbl2.Size = new System.Drawing.Size(592, 38);
            this.ilac_bul_lbl2.TabIndex = 38;
            this.ilac_bul_lbl2.Text = "Hastaya Reçete Edilen Tüm İlaçları Görüntüle\r\n";
            // 
            // frm_HastayaGoreIlacListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 653);
            this.Controls.Add(this.ilac_bul_lbl2);
            this.Controls.Add(this.recete_kontrol_dataGridView);
            this.Controls.Add(this.ilac_kontrol_groupbox);
            this.Name = "frm_HastayaGoreIlacListeleme";
            this.Text = "HASTAYA REÇETE EDİLEN TÜM İLAÇLAR";
            this.ilac_kontrol_groupbox.ResumeLayout(false);
            this.ilac_kontrol_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recete_kontrol_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ilac_kontrol_groupbox;
        private System.Windows.Forms.Label tcKimlikNo_lbl;
        private System.Windows.Forms.TextBox tckimlikNo_txtbox;
        private System.Windows.Forms.Button ilac_listele_btn2;
        private System.Windows.Forms.DataGridView recete_kontrol_dataGridView;
        private System.Windows.Forms.Label ilac_bul_lbl2;
    }
}