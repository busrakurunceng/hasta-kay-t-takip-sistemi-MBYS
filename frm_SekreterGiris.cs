using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Muayene_Bilgi_Yönetimi
{
    public partial class frm_SekreterGiris : Form
    {
        public frm_SekreterGiris()
        {
            InitializeComponent();
        }

        private void sekreter_giris_yap_btn_Click(object sender, EventArgs e)
        {
           
            int sayac = 0;

            if (sekreter_no_textbox.Text == "Ecenur Koç")
            {
                sayac++;
                if (sekreter_sifre_textbox.Text == "12345")
                {
                    frm_SekreterSecenek sekreter_secenek = new frm_SekreterSecenek();
                    MessageBox.Show("İyi günler Ecenur Hanım.Hoşgeldiniz.\nSekreter İşlem Ekranına Yönlendiriliyorsunuz :)");
                    sekreter_secenek.Show();
                }
                else
                {
                    MessageBox.Show("Şifrenizi yanlış girdiniz.Lütfen kontrol ediniz.");
                }

            }

            if (sayac == 0)
            {
                MessageBox.Show("Kullanıcı Adınızı yanlış girdiniz. Lütfen kontrol ediniz.");
            }

            sekreter_no_textbox.Clear();
            sekreter_sifre_textbox.Clear();
        }
    }
}
