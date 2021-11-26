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

        private void TyhjAsBT_Click(object sender, EventArgs e)
        {
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            KayttajaTB.Text = "";
            OsoiteTB.Text = "";
            PnumTB.Text = "";
            PtPaikkaTB.Text = "";
            SalasanaTB.Text = "";
        }


        private void TallAsBT_Click(object sender, EventArgs e)
        {
            String etu = EtunimiTB.Text;
            String suku = SukunimiTB.Text;
            String ktj = KayttajaTB.Text;
            String oso = OsoiteTB.Text;
            String posnum = PnumTB.Text;
            String ppaik = PtPaikkaTB.Text;
            String sala = SalasanaTB.Text;

            if (etu.Trim().Equals("") || suku.Trim().Equals("") || ktj.Trim().Equals("") || oso.Trim().Equals("") || posnum.Trim().Equals("") || ppaik.Trim().Equals("") || sala.Trim().Equals(""))
            {
                MessageBox.Show("Error, Täytä kaikki kentät jatkaaksesi", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean addNewAsiakas = ASIAKAS.addAsiakas(ktj, etu, suku, oso, posnum, ppaik, sala);
                if (addNewAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Asiakasta ei pystytty lisäämään", "Asiakkaan lisäys epäonnistui", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AsiakkaatDG.DataSource = ASIAKAS.getAsiakkaat();
        }

        private void MuokAsBT_Click(object sender, EventArgs e)
        {
            String etu = EtunimiTB.Text;
            String suku = SukunimiTB.Text;
            String ktj = KayttajaTB.Text;
            String oso = OsoiteTB.Text;
            String posnum = PnumTB.Text;
            String ppaik = PtPaikkaTB.Text;
            String sala = SalasanaTB.Text;

            if (etu.Trim().Equals("") || suku.Trim().Equals("") || ktj.Trim().Equals("") || oso.Trim().Equals("") || posnum.Trim().Equals("") || ppaik.Trim().Equals("") || sala.Trim().Equals(""))
            {
                MessageBox.Show("Error, Täytä kaikki kentät jatkaaksesi", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean addNewAsiakas = ASIAKAS.editAsiakas(ktj, etu, suku, oso, posnum, ppaik, sala);
                if (addNewAsiakas)
                {
                    MessageBox.Show("Asiakas päivitetty onnistuneesti", "Päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Asiakkaan päivitys epäonnistui", "Päivitys epäonnistui", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AsiakkaatDG.DataSource = ASIAKAS.getAsiakkaat();
        }

        private void AsiakkaatDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EtunimiTB.Text = AsiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            SukunimiTB.Text = AsiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            KayttajaTB.Text = AsiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            OsoiteTB.Text = AsiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            PnumTB.Text = AsiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            PtPaikkaTB.Text = AsiakkaatDG.CurrentRow.Cells[5].Value.ToString();
            SalasanaTB.Text = AsiakkaatDG.CurrentRow.Cells[6].Value.ToString();
        }
        private void PoisAsBT_Click(object sender, EventArgs e)
        {
            String kayttajanimi = KayttajaTB.Text;
            if (ASIAKAS.deleteAsiakas(kayttajanimi))
            {
                AsiakkaatDG.DataSource = ASIAKAS.getAsiakkaat();
                MessageBox.Show("Asiakas on poistettu", "Poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakasta ei voida poistaa", "Poisto epäonnistui", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjAsBT.PerformClick();

        }
    }
}
