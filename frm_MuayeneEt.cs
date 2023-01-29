using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muayene_Bilgi_Yönetimi
{
    public partial class frm_MuayeneEt : Form
    {
        public frm_MuayeneEt()
        {
            InitializeComponent();
        }

        public static string tcData;
        public static int receteNoData;

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hastane_otomasyonu;User Id=postgres;Password=1234");


        public void muayene_verilerini_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                muayene_et_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }


        private void muayene_kayit_ekle_btn_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int muayene_id = random.Next(1, 1000);
  
            conn.Open();
            
                NpgsqlCommand komut_ekle = new NpgsqlCommand();
                komut_ekle.Connection = conn;

                komut_ekle.Parameters.AddWithValue("@muayene_id", Convert.ToInt32(muayene_id));
                komut_ekle.Parameters.AddWithValue("@tckimlikno", tckimlikNo_txtbox.Text);
                komut_ekle.Parameters.AddWithValue("@muayene_tarihi", DateTime.Now);
                komut_ekle.Parameters.AddWithValue("@hasta_sikayet", sikayet_txtbox.Text);
                komut_ekle.Parameters.AddWithValue("@tavsiye_edilen_tedavi", tedavi_txtbox.Text);
                komut_ekle.Parameters.AddWithValue("@recete_no", Convert.ToInt32(recete_no_txtbox.Text));
                komut_ekle.Parameters.AddWithValue("@tani", tani_textbox.Text);

                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into muayeneler values (@muayene_id, @tckimlikno, @muayene_tarihi, @hasta_sikayet, @tavsiye_edilen_tedavi, @recete_no, @tani)";

                komut_ekle.ExecuteNonQuery();
              
                komut_ekle.Dispose();
                MessageBox.Show("Muayene kaydı başarıyla oluşturuldu.");

            


            conn.Close();

            muayene_verilerini_goster("select * from muayeneler");

        }

        private void evet_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Random r = new Random();
            int recete_no = r.Next(100, 1000);
            recete_no_txtbox.Text = recete_no.ToString();
            receteNoData = recete_no;

        }

        private void hayir_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            recete_no_txtbox.Text = null;
        }

        private void recete_yaz_btn_Click(object sender, EventArgs e)
        {
            tcData = tckimlikNo_txtbox.Text.ToString();
            frm_ReceteYaz recete_yaz = new frm_ReceteYaz();
            recete_yaz.Show();
        }
    }
}
