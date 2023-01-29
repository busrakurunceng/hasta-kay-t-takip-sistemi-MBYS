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
    public partial class frm_IlacKontrol : Form
    {
        public frm_IlacKontrol()
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
                ilac_kontrol_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        private void ilac_kontrol_btn_Click(object sender, EventArgs e)
        {
            ilac_goster("select * from ilaclar\nwhere barkod_no = '" + barkodNo_txtbox.Text + "'");

        }
    }
}
