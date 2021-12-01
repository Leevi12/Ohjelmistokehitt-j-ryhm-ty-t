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
            int huone = Convert.ToInt32(HuoneTyyppiCB.SelectedValue.ToString());
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

        private void Varaukset_Load(object sender, EventArgs e)
        {
            HuoneTyyppiCB.DataSource = huone.haeHuoneet();
            HuoneTyyppiCB.DisplayMember = "Huonetyyppi";
            HuoneTyyppiCB.ValueMember = "KategoriaId";

            AsiakasCB.DataSource = asiakas.getAsiakkaat();
            AsiakasCB.DisplayMember = "Kokonimi";
            AsiakasCB.ValueMember = "AsiakasId";
            VarauksetDG.DataSource = varaus.haeVaraukset();

        }
        
        private void HuoneTyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int huonetype = HuoneTyyppiCB.SelectedIndex + 1;
            
            HuoneNroCB.DataSource = huone.tyypillisethuoneet(huonetype);
            HuoneNroCB.DisplayMember = "Huoneen numero";
            HuoneNroCB.ValueMember = "Huoneen numero";
        }

        private void MuokVrBT_Click(object sender, EventArgs e)
        {
            int huone = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            int asiakas = Convert.ToInt32(AsiakasCB.SelectedValue.ToString());
            DateTime sisaan = Convert.ToDateTime(SisaanDTP.Value);
            DateTime ulos = Convert.ToDateTime(UlosDTP.Value);
            try
            {
                int vara = Convert.ToInt32(VrNumeroTB.Text);

                if (varaus.editVaraus(huone, asiakas, sisaan, ulos, vara))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
