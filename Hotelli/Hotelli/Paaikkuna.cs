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

        private void ikkunaYksi_Click(object sender, EventArgs e)
        {
            Form1 formi = new Form1();
            formi.Show();
            // example
        }

        private void ikkunaKaksi_Click(object sender, EventArgs e)
        {

        }

        private void ikkunaKolme_Click(object sender, EventArgs e)
        {

        }
    }
}
