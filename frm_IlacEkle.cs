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
    public partial class frm_IlacEkle : Form
    {
        public frm_IlacEkle()
        {
            InitializeComponent();
        }


        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hastane_otomasyonu;User Id=postgres;Password=1234");


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
                ilac_ekle_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        private void ilac_ekle_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@barkod_no", Convert.ToInt32(ilac_barkod_no_txtbox.Text));
            komut_ekle.Parameters.AddWithValue("@ilac_ad", ilac_ad_textbox.Text);
            komut_ekle.Parameters.AddWithValue("@tip", ilac_tipi_textbox.Text);
           

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ilaclar (barkod_no ,ilac_ad, tip) values (@barkod_no, @ilac_ad, @tip)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                ilac_ekle_dataGridView.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();

            ilac_goster("select * from ilaclar");
        }
    }
}
