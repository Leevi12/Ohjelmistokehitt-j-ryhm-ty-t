using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotelli
{
    class Asiakas
    {
        Yhdista yhteys = new Yhdista();

        public bool addAsiakas(String ktj, String etu, String suku, String oso, String pnum, String ppaik, String sala)
        {
            MySqlCommand komento = new MySqlCommand();
            String adding = "INSERT INTO asiakkaat " +
                "(kayttajanimi, etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, salasana) " +
                "VALUES (@ktj, @etu, @suku, @oso, @pnum, @ppaik, @sala); ";
            komento.CommandText = adding;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@ktj", MySqlDbType.VarChar).Value = ktj;
            komento.Parameters.Add("@etu", MySqlDbType.VarChar).Value = etu;
            komento.Parameters.Add("@suku", MySqlDbType.VarChar).Value = suku;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = oso;
            komento.Parameters.Add("@pnum", MySqlDbType.VarChar).Value = pnum;
            komento.Parameters.Add("@ppaik", MySqlDbType.VarChar).Value = ppaik;
            komento.Parameters.Add("@sala", MySqlDbType.VarChar).Value = sala;

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
        public DataTable getAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT kayttajanimi, etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, salasana FROM asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool editAsiakas(String ktj, String etu, String suku, String oso, String pnum, String ppaik, String sala)
        {
            MySqlCommand komento = new MySqlCommand();
            String updating = "UPDATE asiakkaat SET etunimi = @etu, sukunimi = @suku, lahiosoite = @oso, postinumero = @pnum, postitoimipaikka = @ppaik, salasana = @sala WHERE kayttajanimi = @ktj";
            komento.CommandText = updating;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@ktj", MySqlDbType.VarChar).Value = ktj;
            komento.Parameters.Add("@etu", MySqlDbType.VarChar).Value = etu;
            komento.Parameters.Add("@suku", MySqlDbType.UInt32).Value = suku;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = oso;
            komento.Parameters.Add("@pnum", MySqlDbType.VarChar).Value = pnum;
            komento.Parameters.Add("@ppaik", MySqlDbType.VarChar).Value = ppaik;
            komento.Parameters.Add("@sala", MySqlDbType.VarChar).Value = sala;

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
        public bool deleteAsiakas(String kayttajanimi)
        {
            MySqlCommand komento = new MySqlCommand();
            String deleting = "DELETE FROM asiakkaat WHERE AsiakasID = @aid";
            komento.CommandText = deleting;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@aid", MySqlDbType.UInt32).Value = kayttajanimi;

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
