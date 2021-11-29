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

        public DataTable haeHuoneet()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huoneet", yhteys.otaYhteys());
            MySqlDataAdapter adap = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adap.SelectCommand = komento;
            adap.Fill(taulu);
            return taulu;
        }

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

        public bool poistaHuone(string hnro)
        {
            MySqlCommand komento = new MySqlCommand();
            string poisto = "DELETE FROM huoneet WHERE huoneNro = @hno";
            komento.CommandText = poisto;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;

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

        public bool muokkaHuone(int hnro, int htyyppi, string puh, string vap)
        {
            MySqlCommand komento = new MySqlCommand();
            return true;
        }
    }
}
