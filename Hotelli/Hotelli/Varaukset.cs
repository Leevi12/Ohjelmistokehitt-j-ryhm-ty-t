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

                if (varaus.editVaraus(vara, huone, asiakas, sisaan, ulos))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneen muokkaus", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: "+ ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void VarauksetDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VarauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VrNumeroTB.Text = VarauksetDG.CurrentRow.Cells[0].Value.ToString();
            AsiakasCB.Text = VarauksetDG.CurrentRow.Cells[1].Value.ToString();
            HuoneNroCB.Text = VarauksetDG.CurrentRow.Cells[2].Value.ToString();
            SisaanDTP.Text = VarauksetDG.CurrentRow.Cells[3].Value.ToString();
            UlosDTP.Text = VarauksetDG.CurrentRow.Cells[4].Value.ToString();
        }

        private void PoisVrBT_Click(object sender, EventArgs e)
        {
            try
            {
                String varausnro = VrNumeroTB.Text;
                if (varaus.deleteVaraus(varausnro))
                {
                    VarauksetDG.DataSource = varaus.haeVaraukset();
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Varauksen poisto epäonnistui", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TyhjVrBT.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe " + ex);
            }
        }
    }
}
