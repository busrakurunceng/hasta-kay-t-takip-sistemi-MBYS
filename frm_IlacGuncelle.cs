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
    public partial class frm_IlacGuncelle : Form
    {
        public frm_IlacGuncelle()
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
                ilac_guncelle_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        private void ilac_kontrol_btn_Click(object sender, EventArgs e)
        {
            ilac_goster("select * from ilaclar\nwhere barkod_no = '" + guncellenecek_barkodNo_txtbox.Text + "'");
        }

        private void ilac_guncelle_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@guncellenecek_barkodNo", Convert.ToInt32(guncellenecek_barkodNo_txtbox.Text)); 
            komut_ekle.Parameters.AddWithValue("@barkod_no", Convert.ToInt32(ilac_barkod_no_txtbox.Text));
            komut_ekle.Parameters.AddWithValue("@ilac_ad", ilac_ad_textbox.Text);
            komut_ekle.Parameters.AddWithValue("@tip", ilac_tipi_textbox.Text);


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "update ilaclar set barkod_no=@barkod_no, ilac_ad=@ilac_ad, tip=@tip where barkod_no = @guncellenecek_barkodNo";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                ilac_guncelle_dataGridView.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();

            ilac_goster("select * from ilaclar\nwhere barkod_no = '" + guncellenecek_barkodNo_txtbox.Text + "'");
        }

        public static implicit operator frm_IlacGuncelle(frm_HastaGuncelle v)
        {
            throw new NotImplementedException();
        }
    }
}
