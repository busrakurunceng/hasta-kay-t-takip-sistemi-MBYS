using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Muayene_Bilgi_Yönetimi
{
    public partial class frm_HastaEkle : Form
    {
        public frm_HastaEkle()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hastane_otomasyonu;User Id=postgres;Password=1234");


        public void hastalari_goster(string txt)
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
                hasta_ekle_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        private void hasta_ekle_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@tckimlikno", tckimlikNo_txtbox.Text);
            komut_ekle.Parameters.AddWithValue("@ad", hastaAd_txtbox.Text);
            komut_ekle.Parameters.AddWithValue("@soyad", hastaSoyad_txtbox.Text);
            komut_ekle.Parameters.AddWithValue("@dogum_yeri", dogumYeri_txtbox.Text);
            komut_ekle.Parameters.AddWithValue("@dogum_tarihi", Convert.ToDateTime(dogumTarihi_datetime.Text));
            komut_ekle.Parameters.AddWithValue("@medeni_durumu", medeni_durum_textbox.Text);
            komut_ekle.Parameters.AddWithValue("@adres", adres_txtbox.Text);
            komut_ekle.Parameters.AddWithValue("@telefon", telefon_textbox.Text);



            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into hastalar (tckimlikno , ad, soyad, dogum_yeri, dogum_tarihi, medeni_durumu, adres , telefon) values (@tckimlikno, @ad, @soyad, @dogum_yeri, @dogum_tarihi , @medeni_durumu , @adres , @telefon)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                hasta_ekle_dataGridView.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();

            hastalari_goster("select * from hastalar");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
