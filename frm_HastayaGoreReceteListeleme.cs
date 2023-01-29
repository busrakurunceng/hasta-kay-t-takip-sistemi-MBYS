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
    public partial class frm_HastayaGoreReceteListeleme : Form
    {
        public frm_HastayaGoreReceteListeleme()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hastane_otomasyonu;User Id=postgres;Password=1234");


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
                recete_kontrol_dataGridView2.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        private void recete_kontrol_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void recete_kontrol_btn1_Click(object sender, EventArgs e)
        {

        }

        private void recete_listele_btn2_Click(object sender, EventArgs e)
        {
            recete_goster("select h.tckimlikno,h.ad ,h.soyad ,  r.recete_id , r.tarih, r.ilac_adi1,r.kutu_sayisi1 , r.ilac_adi2,r.kutu_sayisi2 ,r.ilac_adi3,r.kutu_sayisi3 , r.ilac_adi4,r.kutu_sayisi4, r.ilac_adi5,r.kutu_sayisi5, r.doktor_adi\nfrom receteler r \ninner join hastalar h on h.tckimlikno=r.tckimlikno where r.tckimlikno='" + tckimlikNo_txtbox.Text + "' ORDER BY r.tarih ASC");
        }
    }
}
