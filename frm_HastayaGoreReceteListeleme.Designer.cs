namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_HastayaGoreReceteListeleme
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
            this.recete_kontrol_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.recete_bul_lbl2 = new System.Windows.Forms.Label();
            this.hasta_kontrol_groupbox = new System.Windows.Forms.GroupBox();
            this.tcKimlikNo_lbl = new System.Windows.Forms.Label();
            this.tckimlikNo_txtbox = new System.Windows.Forms.TextBox();
            this.recete_listele_btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recete_kontrol_dataGridView2)).BeginInit();
            this.hasta_kontrol_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // recete_kontrol_dataGridView2
            // 
            this.recete_kontrol_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recete_kontrol_dataGridView2.Location = new System.Drawing.Point(35, 277);
            this.recete_kontrol_dataGridView2.Name = "recete_kontrol_dataGridView2";
            this.recete_kontrol_dataGridView2.RowHeadersWidth = 51;
            this.recete_kontrol_dataGridView2.RowTemplate.Height = 24;
            this.recete_kontrol_dataGridView2.Size = new System.Drawing.Size(685, 312);
            this.recete_kontrol_dataGridView2.TabIndex = 35;
            this.recete_kontrol_dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recete_kontrol_dataGridView_CellContentClick);
            // 
            // recete_bul_lbl2
            // 
            this.recete_bul_lbl2.AutoSize = true;
            this.recete_bul_lbl2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recete_bul_lbl2.Location = new System.Drawing.Point(51, 36);
            this.recete_bul_lbl2.Name = "recete_bul_lbl2";
            this.recete_bul_lbl2.Size = new System.Drawing.Size(624, 38);
            this.recete_bul_lbl2.TabIndex = 33;
            this.recete_bul_lbl2.Text = "Hastaya Göre Yazılmış Tüm Reçeteleri Görüntüle";
            // 
            // hasta_kontrol_groupbox
            // 
            this.hasta_kontrol_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hasta_kontrol_groupbox.Controls.Add(this.tcKimlikNo_lbl);
            this.hasta_kontrol_groupbox.Controls.Add(this.tckimlikNo_txtbox);
            this.hasta_kontrol_groupbox.Controls.Add(this.recete_listele_btn2);
            this.hasta_kontrol_groupbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_kontrol_groupbox.Location = new System.Drawing.Point(63, 103);
            this.hasta_kontrol_groupbox.Name = "hasta_kontrol_groupbox";
            this.hasta_kontrol_groupbox.Size = new System.Drawing.Size(612, 153);
            this.hasta_kontrol_groupbox.TabIndex = 36;
            this.hasta_kontrol_groupbox.TabStop = false;
            this.hasta_kontrol_groupbox.Text = "Hasta Kaydı Bul";
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
            // recete_listele_btn2
            // 
            this.recete_listele_btn2.BackColor = System.Drawing.Color.White;
            this.recete_listele_btn2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recete_listele_btn2.Location = new System.Drawing.Point(420, 84);
            this.recete_listele_btn2.Name = "recete_listele_btn2";
            this.recete_listele_btn2.Size = new System.Drawing.Size(163, 63);
            this.recete_listele_btn2.TabIndex = 24;
            this.recete_listele_btn2.Text = "REÇETE LİSTELE";
            this.recete_listele_btn2.UseVisualStyleBackColor = false;
            this.recete_listele_btn2.Click += new System.EventHandler(this.recete_listele_btn2_Click);
            // 
            // frm_HastayaGoreReceteListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 653);
            this.Controls.Add(this.hasta_kontrol_groupbox);
            this.Controls.Add(this.recete_kontrol_dataGridView2);
            this.Controls.Add(this.recete_bul_lbl2);
            this.Name = "frm_HastayaGoreReceteListeleme";
            this.Text = "HASTAYA GÖRE REÇETE LİSTELEME";
            ((System.ComponentModel.ISupportInitialize)(this.recete_kontrol_dataGridView2)).EndInit();
            this.hasta_kontrol_groupbox.ResumeLayout(false);
            this.hasta_kontrol_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recete_kontrol_dataGridView2;
        private System.Windows.Forms.Label recete_bul_lbl2;
        private System.Windows.Forms.GroupBox hasta_kontrol_groupbox;
        private System.Windows.Forms.Label tcKimlikNo_lbl;
        private System.Windows.Forms.TextBox tckimlikNo_txtbox;
        private System.Windows.Forms.Button recete_listele_btn2;
    }
}