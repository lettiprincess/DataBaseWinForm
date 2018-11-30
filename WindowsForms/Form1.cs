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
        const string AdatLetrehozasSql = "create table if not exists felhasznalo(id integer auto_increment primary key, nev varchar(80) not null unique, jelszo varchar(100) not null, regdatum date not null)";

        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            try {
                conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;");
                conn.Open();
                var letrehozas = conn.CreateCommand();
                letrehozas.CommandText = AdatLetrehozasSql;
                letrehozas.ExecuteNonQuery();
            }
            catch (MySqlException e) {
                MessageBox.Show("Adatbázis hiba: " + e);
            }

            regdatumUpdate.Enabled = false;
            button3.Enabled = false;
            nevDel.Enabled = false;
            jelszoDel.Enabled = false;
            button2.Enabled = false;

            var listazas = conn.CreateCommand();
            listazas.CommandText = "SELECT COUNT(*) FROM felhasznalo";
            long darabSzam = (long)listazas.ExecuteScalar();

            var felhasznalok = conn.CreateCommand();
            listazas.CommandText = "SELECT nev,regdatum FROM felhasznalo ORDER BY nev";
            using (var reader = listazas.ExecuteReader()) {
                felhasznalokListBox.Items.Clear();
                while (reader.Read()) {
                    var nev = reader.GetString("nev");
                    var datum = reader.GetDateTime("regdatum");
                    felhasznalokListBox.Items.Add(string.Format("{0:yyyy.MM.dd.} - {1}",datum,nev));
                }
            }
            var stat = conn.CreateCommand();
            stat.CommandText = "SELECT regdatum, COUNT(*) FROM felhasznalo GROUP BY regdatum";
            using (var reader = stat.ExecuteReader()) {
                statLB.Items.Clear();
                while (reader.Read()) {
                    DateTime datum = reader.GetDateTime("regdatum");
                    long db = reader.GetInt64("COUNT(*)");
                    statLB.Items.Add(string.Format("{0:yyyy.MM.dd.} - {1}",datum,db));
                }
            }

            var adapter = new MySqlDataAdapter("SELECT nev,regdatum FROM felhasznalo ORDER BY nev", conn);
            var builder = new MySqlCommandBuilder(adapter);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = nevTB.Text;
            string jelszo = jelszoTB.Text;
            DateTime regDatum = regdatumDTP.Value;
            
                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE nev = @nev";
                ellenorzes.Parameters.AddWithValue("@nev",nev);
                var darab = (long)ellenorzes.ExecuteScalar();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string nevTorles = nevDel.Text;
            string jelszoTorles = jelszoDel.Text;
            
                var command = conn.CreateCommand();
                command.CommandText = "DELETE FROM `felhasznalo` WHERE nev = @nev";
                command.Parameters.AddWithValue("@nev", nevTorles);
                command.Parameters.AddWithValue("@jelszo", jelszoTorles);
                command.ExecuteNonQuery();
            }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string nevBejelntkezes = nevLogin.Text;
            DateTime regDatumMod = regdatumUpdate.Value;
            
                var command = conn.CreateCommand();
                command.CommandText = "UPDATE `felhasznalo` SET regdatum = @regdatum WHERE nev = @nev";
                command.Parameters.AddWithValue("@nev",nevBejelntkezes);
                command.Parameters.AddWithValue("@regDatum", regDatumMod);
                command.ExecuteNonQuery();
            }

        private void login_Click(object sender, EventArgs e)
        {
            string nevBejelntkezes = nevLogin.Text;
            string jelszoBejelentkezes = jelszoLogin.Text;
            
            var ellenorzes = conn.CreateCommand();
            ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE nev = @nev and jelszo = @jelszo";
            ellenorzes.Parameters.AddWithValue("@nev", nevBejelntkezes);
            ellenorzes.Parameters.AddWithValue("@jelszo", jelszoBejelentkezes);
            var darab = (long)ellenorzes.ExecuteScalar();
            if (darab == 0)
            {
                regdatumUpdate.Enabled = false;
                button3.Enabled = false;
                nevDel.Enabled = false;
                jelszoDel.Enabled = false;
                button2.Enabled = false;
                MessageBox.Show("Nem van ilyen felhasználó!");
                return;
            }
            else {
                button3.Enabled = true;
                regdatumUpdate.Enabled = true;
                nevDel.Enabled = true;
                jelszoDel.Enabled = true;
                button2.Enabled = true;
            }
        }
    }
}
