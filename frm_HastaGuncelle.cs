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
    public partial class frm_HastaGuncelle : Form
    {
        public frm_HastaGuncelle()
        {
            InitializeComponent();
        }


        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hastane_otomasyonu;User Id=postgres;Password=1234");


        public void hasta_goster(string txt)
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
                hasta_guncelle_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        

        private void hasta_guncelle_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;


            komut_ekle.Parameters.AddWithValue("@guncellenecek_tckimlikno", guncellenecek_tckimlikNo_txtbox.Text); ;
            komut_ekle.Parameters.AddWithValue("@tckimlikno", textBox1.Text);
            komut_ekle.Parameters.AddWithValue("@ad", hastaAd_txtbox.Text);
            komut_ekle.Parameters.AddWithValue("@soyad", hastaSoyad_txtbox.Text);
            komut_ekle.Parameters.AddWithValue("@dogum_yeri", dogumYeri_txtbox.Text);
            komut_ekle.Parameters.AddWithValue("@dogum_tarihi", Convert.ToDateTime(dogumTarihi_datetime.Text));
            komut_ekle.Parameters.AddWithValue("@medeni_durumu", medeni_durum_textbox.Text);
            komut_ekle.Parameters.AddWithValue("@adres", adres_txtbox.Text);
            komut_ekle.Parameters.AddWithValue("@telefon", telefon_textbox.Text);



            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "update hastalar set tckimlikno=@tckimlikno, ad=@ad, soyad=@soyad, dogum_yeri=@dogum_yeri, dogum_tarihi=@dogum_tarihi , medeni_durumu=@medeni_durumu , adres=@adres , telefon=@telefon where tckimlikno = @guncellenecek_tckimlikno";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                hasta_guncelle_dataGridView.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();

            hasta_goster("select * from hastalar\n where tckimlikno = '" + guncellenecek_tckimlikNo_txtbox.Text + "'");
        }

        private void hasta_kontrol_btn_Click(object sender, EventArgs e)
        {
            hasta_goster("select * from hastalar\nwhere tckimlikno = '" + guncellenecek_tckimlikNo_txtbox.Text + "'");
        }
    }
}
