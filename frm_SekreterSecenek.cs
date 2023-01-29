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
    public partial class frm_SekreterSecenek : Form
    {
        public frm_SekreterSecenek()
        {
            InitializeComponent();
        }

        private void hASTAEKLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HastaEkle hasta_ekle = new frm_HastaEkle();
            hasta_ekle.MdiParent = this;
            hasta_ekle.Show();
        }

        private void hASTALİSTELEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HastaKontrol hasta_kontrol = new frm_HastaKontrol();
            hasta_kontrol.MdiParent = this;
            hasta_kontrol.Show();
        }

        private void iLAÇEKLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_IlacEkle ilac_ekle = new frm_IlacEkle();
            ilac_ekle.MdiParent = this;
            ilac_ekle.Show();
        }

        private void iLAÇLİSTELEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_IlacKontrol ilac_kontrol = new frm_IlacKontrol();
            ilac_kontrol.MdiParent = this;
            ilac_kontrol.Show();
        }

        private void hASTAGÜNCELLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HastaGuncelle hasta_guncelle = new frm_HastaGuncelle();
            hasta_guncelle.MdiParent = this;
            hasta_guncelle.Show();
        }

        private void iLAÇGÜNCELLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_IlacGuncelle hasta_guncelle = new frm_IlacGuncelle();
            hasta_guncelle.MdiParent = this;
            hasta_guncelle.Show();
        }
    }
}
