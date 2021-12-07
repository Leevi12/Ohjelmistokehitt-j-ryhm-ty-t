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

        private void Varaukset_Load(object sender, EventArgs e)
        {

            VarauksetDG.DataSource = varaus.haeVaraukset();

            HuoneTyyppiCB.ValueMember = "KategoriaId";
            HuoneTyyppiCB.DataSource = huone.TyypillisetHuoneet();
            HuoneTyyppiCB.DisplayMember = "Huonetyyppi";

            AsiakasCB.ValueMember = "AsiakasID";
            AsiakasCB.DisplayMember = "Kokonimi";
            AsiakasCB.DataSource = asiakas.getAsiakkaat();

            HuoneNroCB.DataSource = huone.TyypillisetHuoneet();
            HuoneNroCB.ValueMember = "HuoneNro";
            HuoneNroCB.DisplayMember = "HuoneNro";
            

        }

        private void TallVrBT_Click(object sender, EventArgs e)
        {
            
            int asiakas = Convert.ToInt32(AsiakasCB.SelectedValue.ToString());
            String huonetyyppi = HuoneTyyppiCB.SelectedValue.ToString();
            int huonenumero = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(SisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(UlosDTP.Value);

            if (varaus.addVaraus(asiakas, huonetyyppi, huonenumero, sisaankirjautuminen, uloskirjautuminen))
            {
                MessageBox.Show("Varauksen lisäys onnistui", "Varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Varauksen lisäys epäonnistui", "Varaus epäonnistui", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void HuoneTyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            HuoneNroCB.ValueMember = "Huonetyyppi"; 
            HuoneNroCB.DisplayMember = "Huonetyyppi";
            HuoneNroCB.DataSource = huone.TyypillisetHuoneet();

        }

        private void AsiakasCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            AsiakasCB.ValueMember = "AsiakasID";
            AsiakasCB.DisplayMember = "Kokonimi";
            AsiakasCB.DataSource = asiakas.getAsiakkaat();

        }

        private void HuoneNroCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            HuoneNroCB.ValueMember = "HuoneNro";
            HuoneNroCB.DisplayMember = "HuoneNro";
            HuoneNroCB.DataSource = huone.TyypillisetHuoneet();
        }

        private void MuokVrBT_Click(object sender, EventArgs e)
        {
            int huonenumero = Convert.ToInt32(HuoneNroCB.SelectedValue.ToString());
            String huonetyyppi = HuoneTyyppiCB.SelectedValue.ToString();
            int asiakas = Convert.ToInt32(AsiakasCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(SisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(UlosDTP.Value);
            try
            {
                int vara = Convert.ToInt32(VrNumeroTB.Text);

                if (varaus.editVaraus(vara, asiakas, huonetyyppi, huonenumero, sisaankirjautuminen, uloskirjautuminen))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe " + ex);
            }
            TyhjVrBT.PerformClick();
        }
    }
}
