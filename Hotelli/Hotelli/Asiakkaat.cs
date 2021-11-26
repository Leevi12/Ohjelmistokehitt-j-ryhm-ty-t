using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotelli
{
    public partial class Asiakkaat : Form
    {
        public Asiakkaat()
        {
            InitializeComponent();
        }

        Asiakas ASIAKAS = new Asiakas();
        private void Asiakkaat_Load(object sender, EventArgs e)
        {
            AsiakkaatDG.DataSource = ASIAKAS.getAsiakkaat();
        }
    }
}
