using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotelli
{
    class Yhdista
    {
        public string yhteyslause()
        {
            return "datasource=localhost; port=3306; username=root; password=; database=Hotelli; SSL mode = None";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=Hotelli; SSL mode = None");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }
        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
