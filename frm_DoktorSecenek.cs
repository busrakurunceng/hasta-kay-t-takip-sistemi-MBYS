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
    public partial class frm_DoktorSecenek : Form
    {
        public frm_DoktorSecenek()
        {
            InitializeComponent();
        }

        private void dOKTORAGÖREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DoktoraGoreReceteListeleme doktora_gore_recete = new frm_DoktoraGoreReceteListeleme();
            doktora_gore_recete.MdiParent = this;
            doktora_gore_recete.Show();
        }

        private void hASTAYAGÖREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HastayaGoreReceteListeleme hastaya_gore_recete = new frm_HastayaGoreReceteListeleme();
            hastaya_gore_recete.MdiParent = this;
            hastaya_gore_recete.Show();
        }

        private void hASTAYAGÖREToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_HastayaGoreIlacListeleme hastaya_gore_ilac = new frm_HastayaGoreIlacListeleme();
            hastaya_gore_ilac.MdiParent = this; 
            hastaya_gore_ilac.Show();
        }

        private void iLACAGÖREToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_IlacaGoreReceteListeleme ilaca_gore_recete = new frm_IlacaGoreReceteListeleme();
            ilaca_gore_recete.MdiParent = this;
            ilaca_gore_recete.Show();

        }

        private void hASTALİSTELEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MuayeneEt muayene_et= new frm_MuayeneEt();
            muayene_et.MdiParent = this;
            muayene_et.Show();
        }

        private void iLAÇEKLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
