namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_IlacKontrol
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
            this.ilac_bul_lbl2 = new System.Windows.Forms.Label();
            this.ilac_bul_lbl1 = new System.Windows.Forms.Label();
            this.ilac_kontrol_dataGridView = new System.Windows.Forms.DataGridView();
            this.ilac_kontrol_groupbox = new System.Windows.Forms.GroupBox();
            this.barkodNo_lbl = new System.Windows.Forms.Label();
            this.barkodNo_txtbox = new System.Windows.Forms.TextBox();
            this.ilac_kontrol_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ilac_kontrol_dataGridView)).BeginInit();
            this.ilac_kontrol_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilac_bul_lbl2
            // 
            this.ilac_bul_lbl2.AutoSize = true;
            this.ilac_bul_lbl2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold);
            this.ilac_bul_lbl2.Location = new System.Drawing.Point(194, 93);
            this.ilac_bul_lbl2.Name = "ilac_bul_lbl2";
            this.ilac_bul_lbl2.Size = new System.Drawing.Size(363, 38);
            this.ilac_bul_lbl2.TabIndex = 30;
            this.ilac_bul_lbl2.Text = "Barkod Numarasını Giriniz";
            // 
            // ilac_bul_lbl1
            // 
            this.ilac_bul_lbl1.AutoSize = true;
            this.ilac_bul_lbl1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_bul_lbl1.Location = new System.Drawing.Point(39, 55);
            this.ilac_bul_lbl1.Name = "ilac_bul_lbl1";
            this.ilac_bul_lbl1.Size = new System.Drawing.Size(645, 38);
            this.ilac_bul_lbl1.TabIndex = 29;
            this.ilac_bul_lbl1.Text = "Lütfen Bilgilerini Görüntülemek İstediğiniz İlacın\r\n";
            // 
            // ilac_kontrol_dataGridView
            // 
            this.ilac_kontrol_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilac_kontrol_dataGridView.Location = new System.Drawing.Point(36, 346);
            this.ilac_kontrol_dataGridView.Name = "ilac_kontrol_dataGridView";
            this.ilac_kontrol_dataGridView.RowHeadersWidth = 51;
            this.ilac_kontrol_dataGridView.RowTemplate.Height = 24;
            this.ilac_kontrol_dataGridView.Size = new System.Drawing.Size(685, 262);
            this.ilac_kontrol_dataGridView.TabIndex = 28;
            // 
            // ilac_kontrol_groupbox
            // 
            this.ilac_kontrol_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ilac_kontrol_groupbox.Controls.Add(this.barkodNo_lbl);
            this.ilac_kontrol_groupbox.Controls.Add(this.barkodNo_txtbox);
            this.ilac_kontrol_groupbox.Controls.Add(this.ilac_kontrol_btn);
            this.ilac_kontrol_groupbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilac_kontrol_groupbox.Location = new System.Drawing.Point(72, 155);
            this.ilac_kontrol_groupbox.Name = "ilac_kontrol_groupbox";
            this.ilac_kontrol_groupbox.Size = new System.Drawing.Size(612, 153);
            this.ilac_kontrol_groupbox.TabIndex = 31;
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
            // barkodNo_txtbox
            // 
            this.barkodNo_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodNo_txtbox.Location = new System.Drawing.Point(232, 46);
            this.barkodNo_txtbox.Name = "barkodNo_txtbox";
            this.barkodNo_txtbox.Size = new System.Drawing.Size(150, 24);
            this.barkodNo_txtbox.TabIndex = 16;
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
            // frm_IlacKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 653);
            this.Controls.Add(this.ilac_bul_lbl2);
            this.Controls.Add(this.ilac_bul_lbl1);
            this.Controls.Add(this.ilac_kontrol_dataGridView);
            this.Controls.Add(this.ilac_kontrol_groupbox);
            this.Name = "frm_IlacKontrol";
            this.Text = "İLAÇ KAYDI BULMA";
            ((System.ComponentModel.ISupportInitialize)(this.ilac_kontrol_dataGridView)).EndInit();
            this.ilac_kontrol_groupbox.ResumeLayout(false);
            this.ilac_kontrol_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ilac_bul_lbl2;
        private System.Windows.Forms.Label ilac_bul_lbl1;
        private System.Windows.Forms.DataGridView ilac_kontrol_dataGridView;
        private System.Windows.Forms.GroupBox ilac_kontrol_groupbox;
        private System.Windows.Forms.Label barkodNo_lbl;
        private System.Windows.Forms.TextBox barkodNo_txtbox;
        private System.Windows.Forms.Button ilac_kontrol_btn;
    }
}