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
    public partial class Varaukset : Form
    {
        HUONEET huone = new HUONEET();
        Asiakas asiakas = new Asiakas();
        Varaus varaus = new Varaus();

        public Varaukset()
        {
            InitializeComponent();
        }

        private void TallVrBT_Click(object sender, EventArgs e)
        {
            int asiakas = Convert.ToInt32(AsiakasCB.SelectedValue.ToString());
            int huone = Convert.ToInt32(HuoTyypCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(SisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(UlosDTP.Value);
            
            if (varaus.addVaraus(huone, asiakas, sisaankirjautuminen, uloskirjautuminen))
            {
                MessageBox.Show("Varauksen lisäys onnistui", "Varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
            {
                    MessageBox.Show("Varauksen lisäys epäonnistui", "Varaus epäonnistui", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }
    }
        //}

        //private void Varaukset_Load(object sender, EventArgs e)
        //{

        //}
    //}
}
