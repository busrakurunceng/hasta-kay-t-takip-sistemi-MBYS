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
    public partial class frm_HastaKontrol : Form
    {
        public frm_HastaKontrol()
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
                hasta_kontrol_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }
        private void hasta_kontrol_btn_Click(object sender, EventArgs e)
        {
            hastalari_goster("select * from hastalar\nwhere tckimlikno = '" + tckimlikNo_txtbox.Text + "'");
        }
    }
}
