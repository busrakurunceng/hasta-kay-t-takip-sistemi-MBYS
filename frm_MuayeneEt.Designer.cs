namespace Muayene_Bilgi_Yönetimi
{
    partial class frm_MuayeneEt
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
            this.tcKimlikNo_lbl = new System.Windows.Forms.Label();
            this.sikayet_txtbox = new System.Windows.Forms.RichTextBox();
            this.sikayet_lbl = new System.Windows.Forms.Label();
            this.tckimlikNo_txtbox = new System.Windows.Forms.TextBox();
            this.tedavi_lbl = new System.Windows.Forms.Label();
            this.tedavi_txtbox = new System.Windows.Forms.RichTextBox();
            this.tani_textbox = new System.Windows.Forms.RichTextBox();
            this.tani_lbl = new System.Windows.Forms.Label();
            this.recete_lbl = new System.Windows.Forms.Label();
            this.evet_checkBox = new System.Windows.Forms.CheckBox();
            this.hayir_checkBox = new System.Windows.Forms.CheckBox();
            this.muayene_et_dataGridView = new System.Windows.Forms.DataGridView();
            this.recete_no_txtbox = new System.Windows.Forms.TextBox();
            this.muayene_et_lbl = new System.Windows.Forms.Label();
            this.muayene_kayit_ekle_btn = new System.Windows.Forms.Button();
            this.recete_yaz_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.muayene_et_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tcKimlikNo_lbl
            // 
            this.tcKimlikNo_lbl.AutoSize = true;
            this.tcKimlikNo_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcKimlikNo_lbl.Location = new System.Drawing.Point(1, 87);
            this.tcKimlikNo_lbl.Name = "tcKimlikNo_lbl";
            this.tcKimlikNo_lbl.Size = new System.Drawing.Size(152, 20);
            this.tcKimlikNo_lbl.TabIndex = 17;
            this.tcKimlikNo_lbl.Text = "TC Kimlik No:";
            // 
            // sikayet_txtbox
            // 
            this.sikayet_txtbox.Location = new System.Drawing.Point(192, 153);
            this.sikayet_txtbox.Name = "sikayet_txtbox";
            this.sikayet_txtbox.Size = new System.Drawing.Size(200, 125);
            this.sikayet_txtbox.TabIndex = 18;
            this.sikayet_txtbox.Text = "";
            // 
            // sikayet_lbl
            // 
            this.sikayet_lbl.AutoSize = true;
            this.sikayet_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sikayet_lbl.Location = new System.Drawing.Point(1, 154);
            this.sikayet_lbl.Name = "sikayet_lbl";
            this.sikayet_lbl.Size = new System.Drawing.Size(174, 20);
            this.sikayet_lbl.TabIndex = 20;
            this.sikayet_lbl.Text = "Hasta Şikayeti:";
            // 
            // tckimlikNo_txtbox
            // 
            this.tckimlikNo_txtbox.Location = new System.Drawing.Point(192, 85);
            this.tckimlikNo_txtbox.Name = "tckimlikNo_txtbox";
            this.tckimlikNo_txtbox.Size = new System.Drawing.Size(200, 22);
            this.tckimlikNo_txtbox.TabIndex = 19;
            // 
            // tedavi_lbl
            // 
            this.tedavi_lbl.AutoSize = true;
            this.tedavi_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tedavi_lbl.Location = new System.Drawing.Point(415, 87);
            this.tedavi_lbl.Name = "tedavi_lbl";
            this.tedavi_lbl.Size = new System.Drawing.Size(86, 20);
            this.tedavi_lbl.TabIndex = 21;
            this.tedavi_lbl.Text = "Tedavi:";
            // 
            // tedavi_txtbox
            // 
            this.tedavi_txtbox.Location = new System.Drawing.Point(516, 86);
            this.tedavi_txtbox.Name = "tedavi_txtbox";
            this.tedavi_txtbox.Size = new System.Drawing.Size(200, 125);
            this.tedavi_txtbox.TabIndex = 22;
            this.tedavi_txtbox.Text = "";
            // 
            // tani_textbox
            // 
            this.tani_textbox.Location = new System.Drawing.Point(516, 238);
            this.tani_textbox.Name = "tani_textbox";
            this.tani_textbox.Size = new System.Drawing.Size(200, 125);
            this.tani_textbox.TabIndex = 23;
            this.tani_textbox.Text = "";
            // 
            // tani_lbl
            // 
            this.tani_lbl.AutoSize = true;
            this.tani_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tani_lbl.Location = new System.Drawing.Point(415, 238);
            this.tani_lbl.Name = "tani_lbl";
            this.tani_lbl.Size = new System.Drawing.Size(64, 20);
            this.tani_lbl.TabIndex = 24;
            this.tani_lbl.Text = "Tanı:";
            // 
            // recete_lbl
            // 
            this.recete_lbl.AutoSize = true;
            this.recete_lbl.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recete_lbl.Location = new System.Drawing.Point(12, 319);
            this.recete_lbl.Name = "recete_lbl";
            this.recete_lbl.Size = new System.Drawing.Size(251, 17);
            this.recete_lbl.TabIndex = 25;
            this.recete_lbl.Text = "Reçete Oluşturacak Mısınız?";
            // 
            // evet_checkBox
            // 
            this.evet_checkBox.AutoSize = true;
            this.evet_checkBox.Location = new System.Drawing.Point(30, 361);
            this.evet_checkBox.Name = "evet_checkBox";
            this.evet_checkBox.Size = new System.Drawing.Size(65, 20);
            this.evet_checkBox.TabIndex = 26;
            this.evet_checkBox.Text = "EVET";
            this.evet_checkBox.UseVisualStyleBackColor = true;
            this.evet_checkBox.CheckedChanged += new System.EventHandler(this.evet_checkBox_CheckedChanged);
            // 
            // hayir_checkBox
            // 
            this.hayir_checkBox.AutoSize = true;
            this.hayir_checkBox.Location = new System.Drawing.Point(158, 361);
            this.hayir_checkBox.Name = "hayir_checkBox";
            this.hayir_checkBox.Size = new System.Drawing.Size(70, 20);
            this.hayir_checkBox.TabIndex = 27;
            this.hayir_checkBox.Text = "HAYIR";
            this.hayir_checkBox.UseVisualStyleBackColor = true;
            this.hayir_checkBox.CheckedChanged += new System.EventHandler(this.hayir_checkBox_CheckedChanged);
            // 
            // muayene_et_dataGridView
            // 
            this.muayene_et_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muayene_et_dataGridView.Location = new System.Drawing.Point(31, 422);
            this.muayene_et_dataGridView.Name = "muayene_et_dataGridView";
            this.muayene_et_dataGridView.RowHeadersWidth = 51;
            this.muayene_et_dataGridView.RowTemplate.Height = 24;
            this.muayene_et_dataGridView.Size = new System.Drawing.Size(685, 312);
            this.muayene_et_dataGridView.TabIndex = 39;
            // 
            // recete_no_txtbox
            // 
            this.recete_no_txtbox.Enabled = false;
            this.recete_no_txtbox.Location = new System.Drawing.Point(250, 359);
            this.recete_no_txtbox.Name = "recete_no_txtbox";
            this.recete_no_txtbox.Size = new System.Drawing.Size(100, 22);
            this.recete_no_txtbox.TabIndex = 40;
            // 
            // muayene_et_lbl
            // 
            this.muayene_et_lbl.AutoSize = true;
            this.muayene_et_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.muayene_et_lbl.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.muayene_et_lbl.ForeColor = System.Drawing.Color.White;
            this.muayene_et_lbl.Location = new System.Drawing.Point(229, 23);
            this.muayene_et_lbl.Name = "muayene_et_lbl";
            this.muayene_et_lbl.Size = new System.Drawing.Size(272, 38);
            this.muayene_et_lbl.TabIndex = 41;
            this.muayene_et_lbl.Text = "Muayane Kaydı Ekle";
            // 
            // muayene_kayit_ekle_btn
            // 
            this.muayene_kayit_ekle_btn.BackColor = System.Drawing.Color.White;
            this.muayene_kayit_ekle_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.muayene_kayit_ekle_btn.ForeColor = System.Drawing.Color.Crimson;
            this.muayene_kayit_ekle_btn.Location = new System.Drawing.Point(356, 377);
            this.muayene_kayit_ekle_btn.Name = "muayene_kayit_ekle_btn";
            this.muayene_kayit_ekle_btn.Size = new System.Drawing.Size(163, 39);
            this.muayene_kayit_ekle_btn.TabIndex = 42;
            this.muayene_kayit_ekle_btn.Text = "Kayıt Ekle";
            this.muayene_kayit_ekle_btn.UseVisualStyleBackColor = false;
            this.muayene_kayit_ekle_btn.Click += new System.EventHandler(this.muayene_kayit_ekle_btn_Click);
            // 
            // recete_yaz_btn
            // 
            this.recete_yaz_btn.BackColor = System.Drawing.Color.White;
            this.recete_yaz_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recete_yaz_btn.ForeColor = System.Drawing.Color.Crimson;
            this.recete_yaz_btn.Location = new System.Drawing.Point(553, 377);
            this.recete_yaz_btn.Name = "recete_yaz_btn";
            this.recete_yaz_btn.Size = new System.Drawing.Size(163, 39);
            this.recete_yaz_btn.TabIndex = 43;
            this.recete_yaz_btn.Text = "Reçete Yaz";
            this.recete_yaz_btn.UseVisualStyleBackColor = false;
            this.recete_yaz_btn.Click += new System.EventHandler(this.recete_yaz_btn_Click);
            // 
            // frm_MuayeneEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 746);
            this.Controls.Add(this.recete_yaz_btn);
            this.Controls.Add(this.muayene_kayit_ekle_btn);
            this.Controls.Add(this.muayene_et_lbl);
            this.Controls.Add(this.recete_no_txtbox);
            this.Controls.Add(this.muayene_et_dataGridView);
            this.Controls.Add(this.hayir_checkBox);
            this.Controls.Add(this.evet_checkBox);
            this.Controls.Add(this.recete_lbl);
            this.Controls.Add(this.tani_textbox);
            this.Controls.Add(this.tani_lbl);
            this.Controls.Add(this.tedavi_txtbox);
            this.Controls.Add(this.tedavi_lbl);
            this.Controls.Add(this.tcKimlikNo_lbl);
            this.Controls.Add(this.sikayet_txtbox);
            this.Controls.Add(this.sikayet_lbl);
            this.Controls.Add(this.tckimlikNo_txtbox);
            this.Name = "frm_MuayeneEt";
            this.Text = "MUAYENE ET";
            ((System.ComponentModel.ISupportInitialize)(this.muayene_et_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tcKimlikNo_lbl;
        private System.Windows.Forms.RichTextBox sikayet_txtbox;
        private System.Windows.Forms.Label sikayet_lbl;
        private System.Windows.Forms.TextBox tckimlikNo_txtbox;
        private System.Windows.Forms.Label tedavi_lbl;
        private System.Windows.Forms.RichTextBox tedavi_txtbox;
        private System.Windows.Forms.RichTextBox tani_textbox;
        private System.Windows.Forms.Label tani_lbl;
        private System.Windows.Forms.Label recete_lbl;
        private System.Windows.Forms.CheckBox evet_checkBox;
        private System.Windows.Forms.CheckBox hayir_checkBox;
        private System.Windows.Forms.DataGridView muayene_et_dataGridView;
        private System.Windows.Forms.TextBox recete_no_txtbox;
        private System.Windows.Forms.Label muayene_et_lbl;
        private System.Windows.Forms.Button muayene_kayit_ekle_btn;
        private System.Windows.Forms.Button recete_yaz_btn;
    }
}