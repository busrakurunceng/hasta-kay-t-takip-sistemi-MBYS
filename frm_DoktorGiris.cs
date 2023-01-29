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
    public partial class frm_DoktorGiris : Form
    {
        public frm_DoktorGiris()
        {
            InitializeComponent();
        }

        private void doktor_giris_yap_btn_Click(object sender, EventArgs e)
        {
            int sayac = 0;

            if (doktor_ad_textbox.Text == "Birgül Öztürk")
            {
                sayac++;
                if (doktor_sifre_textbox.Text == "12345")
                {
                    frm_DoktorSecenek doktor_secenek = new frm_DoktorSecenek();
                    MessageBox.Show("Merhaba Sayın Dr. Birgül Hanım, Hoşgeldiniz\nUmarım iyisinizdir  :)");
                    doktor_secenek.Show();
                }
                else
                {
                    MessageBox.Show("Şifrenizi yanlış girdiniz.Lütfen kontrol ediniz.");
                }

            }

            if (sayac == 0)
            {
                MessageBox.Show("Adınızı yanlış girdiniz. Lütfen kontrol ediniz.");
            }

            doktor_ad_textbox.Clear();
            doktor_sifre_textbox.Clear();
        }
    }
}
