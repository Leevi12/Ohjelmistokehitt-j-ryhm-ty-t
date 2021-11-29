﻿using System;
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
            HuoneTyyppiCB.SelectedIndex = 0;
        }

        private void UusiHuoneBT_Click(object sender, EventArgs e)
        {
            string tyyppi = HuoneTyyppiCB.SelectedItem.ToString();
            string puh = PuhelinTB.Text;

            if (huone.lisaaHuone(tyyppi, puh, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huonetta ei pystytty lisäämään", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneetDG.DataSource = huone.haeHuoneet();
        }

        private void HuoneidenHallinta_Load(object sender, EventArgs e)
        {
            HuoneetDG.DataSource = huone.haeHuoneet();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HuoneTyyppiCB.SelectedIndex = 0;
            PuhelinTB.Text = "";
        }

        private void HuoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuoneTyyppiCB.SelectedItem = HuoneetDG.CurrentRow.Cells[1].Value.ToString();
            PuhelinTB.Text = HuoneetDG.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
