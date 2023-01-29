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
    public partial class frm_mbys_giris : Form
    {
        public frm_mbys_giris()
        {
            InitializeComponent();
        }

        private void sekreter_giris_btn_Click(object sender, EventArgs e)
        {
            frm_SekreterGiris sekreter_giris = new frm_SekreterGiris();
            sekreter_giris.Show();
        }

        private void doktor_giris_btn_Click(object sender, EventArgs e)
        {
            frm_DoktorGiris doktor_giris = new frm_DoktorGiris();
            doktor_giris.Show();
        }
    }
}
