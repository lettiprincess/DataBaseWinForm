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

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = nevTB.Text;
            string jelszo = jelszoTB.Text;
            DateTime regDatum = regdatumDTP.Value;
            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;")) {

                conn.Open();

                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE nev = @nev";
                ellenorzes.Parameters.AddWithValue("@nev",nev);
                var darab = (int)ellenorzes.ExecuteScalar();
                if (darab != 0)
                {
                    MessageBox.Show("A név már létezik te szerencsétlen -.-!");
                    return;
                }

                var command = conn.CreateCommand();
                command.CommandText = "INSERT INTO `felhasznalo`(`nev`, `jelszo`, `regdatum`) VALUES (@nev,@jelszo,@regdatum)";
                command.Parameters.AddWithValue("@nev",nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regDatum", regDatum);
                int erintettSorok = command.ExecuteNonQuery();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nevTorles = nevDel.Text;
            string jelszoTorles = jelszoDel.Text;
            
            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;"))
            {
                conn.Open();
                

                var command = conn.CreateCommand();
                command.CommandText = "DELETE FROM `felhasznalo` WHERE jelszo = @jelszo";
                command.Parameters.AddWithValue("@nev", nevTorles);
                command.Parameters.AddWithValue("@jelszo", jelszoTorles);
                command.ExecuteNonQuery();
            }
        }
    }
}
