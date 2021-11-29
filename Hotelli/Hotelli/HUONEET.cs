using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Hotelli
{
    class HUONEET
    {
        Yhdista yhteys = new Yhdista();

        public bool lisaaHuone(string hnTyyppi, string puh, string vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            string lisaaJuttu = "INSERT INTO huoneet (huoneTyyppi, puhelin, vapaa) VALUES (@hty, @puh, @vap)";
            komento.CommandText = lisaaJuttu;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = hnTyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

            yhteys.avaaYhteys();
            try
            {
                if (komento.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return true;
                }
                else
                {
                    yhteys.suljeYhteys();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }
        }
    }
}
