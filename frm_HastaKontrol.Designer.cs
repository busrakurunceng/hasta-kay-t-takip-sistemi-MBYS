namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_HastaKontrol
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
            this.tckimlikNo_txtbox = new System.Windows.Forms.TextBox();
            this.tcKimlikNo_lbl = new System.Windows.Forms.Label();
            this.hasta_kontrol_dataGridView = new System.Windows.Forms.DataGridView();
            this.hasta_kontrol_btn = new System.Windows.Forms.Button();
            this.sekreter_secenek_lbl1 = new System.Windows.Forms.Label();
            this.sekreter_secenek_lbl2 = new System.Windows.Forms.Label();
            this.hasta_kontrol_groupbox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hasta_kontrol_dataGridView)).BeginInit();
            this.hasta_kontrol_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tckimlikNo_txtbox
            // 
            this.tckimlikNo_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tckimlikNo_txtbox.Location = new System.Drawing.Point(242, 46);
            this.tckimlikNo_txtbox.Name = "tckimlikNo_txtbox";
            this.tckimlikNo_txtbox.Size = new System.Drawing.Size(150, 24);
            this.tckimlikNo_txtbox.TabIndex = 16;
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
            // hasta_kontrol_dataGridView
            // 
            this.hasta_kontrol_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hasta_kontrol_dataGridView.Location = new System.Drawing.Point(30, 350);
            this.hasta_kontrol_dataGridView.Name = "hasta_kontrol_dataGridView";
            this.hasta_kontrol_dataGridView.RowHeadersWidth = 51;
            this.hasta_kontrol_dataGridView.RowTemplate.Height = 24;
            this.hasta_kontrol_dataGridView.Size = new System.Drawing.Size(685, 262);
            this.hasta_kontrol_dataGridView.TabIndex = 17;
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
            // sekreter_secenek_lbl1
            // 
            this.sekreter_secenek_lbl1.AutoSize = true;
            this.sekreter_secenek_lbl1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekreter_secenek_lbl1.Location = new System.Drawing.Point(23, 49);
            this.sekreter_secenek_lbl1.Name = "sekreter_secenek_lbl1";
            this.sekreter_secenek_lbl1.Size = new System.Drawing.Size(693, 38);
            this.sekreter_secenek_lbl1.TabIndex = 25;
            this.sekreter_secenek_lbl1.Text = "Lütfen Bilgilerini Görüntülemek İstediğiniz Hastanın \r\n";
            // 
            // sekreter_secenek_lbl2
            // 
            this.sekreter_secenek_lbl2.AutoSize = true;
            this.sekreter_secenek_lbl2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold);
            this.sekreter_secenek_lbl2.Location = new System.Drawing.Point(164, 101);
            this.sekreter_secenek_lbl2.Name = "sekreter_secenek_lbl2";
            this.sekreter_secenek_lbl2.Size = new System.Drawing.Size(405, 38);
            this.sekreter_secenek_lbl2.TabIndex = 26;
            this.sekreter_secenek_lbl2.Text = "TC Kimlik Numarasını Giriniz";
            // 
            // hasta_kontrol_groupbox
            // 
            this.hasta_kontrol_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hasta_kontrol_groupbox.Controls.Add(this.tcKimlikNo_lbl);
            this.hasta_kontrol_groupbox.Controls.Add(this.tckimlikNo_txtbox);
            this.hasta_kontrol_groupbox.Controls.Add(this.hasta_kontrol_btn);
            this.hasta_kontrol_groupbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_kontrol_groupbox.Location = new System.Drawing.Point(68, 159);
            this.hasta_kontrol_groupbox.Name = "hasta_kontrol_groupbox";
            this.hasta_kontrol_groupbox.Size = new System.Drawing.Size(612, 153);
            this.hasta_kontrol_groupbox.TabIndex = 27;
            this.hasta_kontrol_groupbox.TabStop = false;
            this.hasta_kontrol_groupbox.Text = "Hasta Kaydı Bul";
            // 
            // frm_HastaKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 653);
            this.Controls.Add(this.sekreter_secenek_lbl2);
            this.Controls.Add(this.sekreter_secenek_lbl1);
            this.Controls.Add(this.hasta_kontrol_dataGridView);
            this.Controls.Add(this.hasta_kontrol_groupbox);
            this.Name = "frm_HastaKontrol";
            this.Text = "HASTA KAYDI BULMA";
            ((System.ComponentModel.ISupportInitialize)(this.hasta_kontrol_dataGridView)).EndInit();
            this.hasta_kontrol_groupbox.ResumeLayout(false);
            this.hasta_kontrol_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tckimlikNo_txtbox;
        private System.Windows.Forms.Label tcKimlikNo_lbl;
        private System.Windows.Forms.DataGridView hasta_kontrol_dataGridView;
        private System.Windows.Forms.Button hasta_kontrol_btn;
        private System.Windows.Forms.Label sekreter_secenek_lbl1;
        private System.Windows.Forms.Label sekreter_secenek_lbl2;
        private System.Windows.Forms.GroupBox hasta_kontrol_groupbox;
    }
}