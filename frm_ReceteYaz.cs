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
    public partial class frm_ReceteYaz : Form
    {
        public frm_ReceteYaz()
        {
            InitializeComponent();
            tc_kimlik_no_textbox.Text = tcBilgisi.ToString();
            recete_no_txtbox.Text = ReceteBilgisi.ToString();
        }

        string tcBilgisi = frm_MuayeneEt.tcData;
        int ReceteBilgisi = frm_MuayeneEt.receteNoData;

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hastane_otomasyonu;User Id=postgres;Password=1234");



        public void recete_verilerini_goster(string txt)
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
                recete_ekleme_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        public void ilac_goster(string txt)
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
                ilac_listele_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        public void recete_goster(string txt)
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
                recete_ekleme_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }



        private void ilac_listele_btn_Click(object sender, EventArgs e)
        {
            ilac_goster("select * from ilaclar");
        }

        private void recete_listele_btn_Click(object sender, EventArgs e)
        {
            recete_goster("select * from receteler\n where tckimlikno ='" + tc_kimlik_no_textbox.Text + "'");
        }

        private void kutu_sayisi_btn_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt64(kutu_sayisi1_textbox.Text) > 3 || Convert.ToInt64(kutu_sayisi2_textbox.Text) > 3 || Convert.ToInt64(kutu_sayisi3_textbox.Text) > 3 || Convert.ToInt64(kutu_sayisi4_textbox.Text) > 3 || Convert.ToInt64(kutu_sayisi5_textbox.Text) > 3)
            {
                MessageBox.Show("Bir ilaçtan 3ten fazla kutu yazılamaz.");
            }
            else
            {
                conn.Open();
                NpgsqlCommand komut_ekle = new NpgsqlCommand();
                komut_ekle.Connection = conn;

                komut_ekle.Parameters.AddWithValue("@recete_id", Convert.ToInt64(recete_no_txtbox.Text));
                komut_ekle.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut_ekle.Parameters.AddWithValue("@doktor_adi", "Birgül Öztürk");
                komut_ekle.Parameters.AddWithValue("@tckimlikno", tc_kimlik_no_textbox.Text);
                komut_ekle.Parameters.AddWithValue("@ilac_adi1", ilac_adi1_textbox.Text);
                komut_ekle.Parameters.AddWithValue("@kutu_sayisi1", Convert.ToInt32(kutu_sayisi1_textbox.Text));
                komut_ekle.Parameters.AddWithValue("@ilac_adi2", ilac_adi2_textbox.Text);
                komut_ekle.Parameters.AddWithValue("@kutu_sayisi2", Convert.ToInt32(kutu_sayisi2_textbox.Text));
                komut_ekle.Parameters.AddWithValue("@ilac_adi3", ilac_adi3_textbox.Text);
                komut_ekle.Parameters.AddWithValue("@kutu_sayisi3", Convert.ToInt32(kutu_sayisi3_textbox.Text));
                komut_ekle.Parameters.AddWithValue("@ilac_adi4", ilac_adi4_textbox.Text);
                komut_ekle.Parameters.AddWithValue("@kutu_sayisi4", Convert.ToInt32(kutu_sayisi4_textbox.Text));
                komut_ekle.Parameters.AddWithValue("@ilac_adi5", ilac_adi5_textbox.Text);
                komut_ekle.Parameters.AddWithValue("@kutu_sayisi5", Convert.ToInt32(kutu_sayisi5_textbox.Text));


                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into receteler (recete_id, tarih, doktor_adi ,tckimlikno, ilac_adi1,kutu_sayisi1 ,ilac_adi2,kutu_sayisi2 ,ilac_adi3,kutu_sayisi3 , ilac_adi4,kutu_sayisi4, ilac_adi5,kutu_sayisi5 ) values (@recete_id, @tarih, @doktor_adi ,@tckimlikno, @ilac_adi1,@kutu_sayisi1 ,@ilac_adi2,@kutu_sayisi2 ,@ilac_adi3,@kutu_sayisi3 , @ilac_adi4,@kutu_sayisi4, @ilac_adi5,@kutu_sayisi5) ";

                NpgsqlDataReader dr = komut_ekle.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    recete_ekleme_dataGridView.DataSource = dt;
                }
                komut_ekle.Dispose();
                conn.Close();
            }
            
        }
    }
}
