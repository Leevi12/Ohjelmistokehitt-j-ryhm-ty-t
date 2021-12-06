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
    class Varaus
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

        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM varaukset", yhteys.otaYhteys());
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapt.SelectCommand = komento;
            adapt.Fill(taulu);
            return taulu;
        }

        public DataTable getAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool addVaraus(int huonro, int asnro, DateTime sisa, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String adding = "INSERT INTO varaukset " +
                "(HuoneNro, AsiakasNro, Sisaan, Ulos) " +
                "VALUES (@hno, @anro, @sis, @ulo); ";
            komento.CommandText = adding;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = huonro;
            komento.Parameters.Add("@anro", MySqlDbType.Int32).Value = asnro;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisa;
            komento.Parameters.Add("@ulo", MySqlDbType.VarChar).Value = ulos;

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

        public bool editVaraus(int varnro, int huonro, int asnro, DateTime sisa, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String updating = "UPDATE varaukset SET " +
                "HuoneNro = @hno, AsiakasNro = @anro, Sisaan = @sis, Ulos = @ulo " +
                "WHERE VarausNro = @vnro";
            komento.CommandText = updating;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = huonro;
            komento.Parameters.Add("@anro", MySqlDbType.Int32).Value = asnro;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisa;
            komento.Parameters.Add("@ulo", MySqlDbType.VarChar).Value = ulos;
            komento.Parameters.Add("@vnro", MySqlDbType.Int32).Value = varnro;

            yhteys.avaaYhteys();
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
        public bool deleteVaraus(String varausnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String deleting = "DELETE FROM varaukset WHERE VarausID = @vnro";
            komento.CommandText = deleting;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@vnro", MySqlDbType.UInt32).Value = varausnro;

            yhteys.avaaYhteys();
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
    }
}
