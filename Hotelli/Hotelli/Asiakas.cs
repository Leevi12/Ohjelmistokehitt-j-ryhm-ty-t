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
                "(Käyttäjänimi, Etunimi, Sukunimi, Lähiosoite, Postinumero, Postitoimipaikka, Salasana) " +
                "VALUES (@ktj, @etu, @suku, @oso, @pnum, @ppaik, @sala); ";
            komento.CommandText = adding;
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
        public DataTable getAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Käyttäjänimi, Etunimi, Sukunimi, Lähiosoite, Postinumero, Postitoimipaikka, Salasana From asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool editAsiakas(String ktj, String etu, String suku, String oso, String pnum, String ppaik, String sala)
        {
            MySqlCommand komento = new MySqlCommand();
            String updating = "UPDATE asiakkaat SET Etunimi = @etu, Sukunimi = @suku, Lähiosoite = @oso, Postinumero = @pnum, Postitoimipaikka = @ppaik, Salasana = @sala WHERE Käyttäjänimi = @ktj";
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
        public bool deleteAsiakas(String Käyttäjänimi)
        {
            MySqlCommand komento = new MySqlCommand();
            String deleting = "DELETE FROM asiakkaat WHERE Käyttäjänimi = @ktj";
            komento.CommandText = deleting;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@ktj", MySqlDbType.UInt32).Value = Käyttäjänimi;

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
