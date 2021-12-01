using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelli
{
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
        }
        private void ikkunaKaksi_Click(object sender, EventArgs e)
        {
            Asiakkaat asi = new Asiakkaat();
            asi.Show();
        }

        private void ikkunaKolme_Click(object sender, EventArgs e)
        {
            HuoneidenHallinta huoneet = new HuoneidenHallinta();
            huoneet.Show(); 
        }

        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varaukset var = new Varaukset();
            var.Show();
        }
    }
}
