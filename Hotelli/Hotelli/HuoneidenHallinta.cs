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
    public partial class HuoneidenHallinta : Form
    {
        HUONEET huone = new HUONEET();
        public HuoneidenHallinta()
        {
            InitializeComponent();
        }

        private void UusiHuoneBT_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(HuoneNoTB.Text);
            int tyyppi = Convert.ToInt32(HuoneTyyppiCB.SelectedValue.ToString());
            string puh = PuhelinTB.Text;

            if (huone.lisaaHuone(num, tyyppi, puh, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
