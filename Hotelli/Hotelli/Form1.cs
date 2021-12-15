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
    public partial class Form1 : Form
    {
        Yhdista yhteys = new Yhdista();
        public Form1()
        {
            InitializeComponent();
        }

        private void SignInBT_Click(object sender, EventArgs e)
        {
            String nimi = UsernameTB.Text;
            String salasana = PasswordTB.Text;
            if (UsernameTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
            }
            else
            {
                MySqlCommand komento = new MySqlCommand();
                String komentoteksti = "SELECT * FROM asiakkaat WHERE kayttajanimi = @user AND salasana = @pass";
                komento.CommandText = komentoteksti;
                komento.Connection = yhteys.otaYhteys();
                komento.Parameters.Add("@user", MySqlDbType.VarChar).Value = nimi;
                komento.Parameters.Add("@pass", MySqlDbType.VarChar).Value = salasana;
                

                yhteys.avaaYhteys();
               //MessageBox.Show(komento.CommandText);
                if (komento.ExecuteNonQuery() == 1)
                {
                    MySqlDataReader dataReader = komento.ExecuteReader();
                    MessageBox.Show("Kukkuu");
                    if (dataReader.HasRows)
                    {
                        Paaikkuna joulupukki = new Paaikkuna();
                        this.Close();
                        joulupukki.Show();
                    }
                    else
                    {
                        MessageBox.Show("Rivejä ei ollut");
                    }
                    dataReader.Close();
        
                    
                }
                else
                {
                    //MessageBox.Show("Virhe");
                    Paaikkuna joulupukki = new Paaikkuna();
                    joulupukki.ShowDialog();
                    this.Close();


                    yhteys.suljeYhteys();
                }
                
            }
            
        }
    }
}
