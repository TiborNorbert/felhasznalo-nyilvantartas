using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace felhasznalo_nyilvantartas
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sqlCommand = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "felhasznalonyilvantartas";
            conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                conn.Open();
                sqlCommand = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program le fog állni!!!!!");
                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }
        }
        private void felhasznalonevbetolt()
        {
            lista.Items.Clear();
            sqlCommand.CommandText = "SELECT `id`,`nev`,`szuletesidatum`,`profilkepnev` FROM `felhasznalo` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = sqlCommand.ExecuteReader())
            {
                while (dr.Read())
                {
                    adat uj = new adat(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDateTime("szuletesidatum"), dr.GetString("profilkepnev"));
                    lista.Items.Add(uj);
                }
            }
            conn.Close();
        }
        private bool nincsadat()
        {
            if (string.IsNullOrEmpty(nevtxt.Text))
            {
                MessageBox.Show("Adja meg a Nevét");
                nevtxt.Focus();
                return true;
            }
            return false;
        }

        private void addb_Click(object sender, EventArgs e)
        {
            if (nincs_adat())
            {
                return;
            }
            sqlCommand.CommandText = "INSERT INTO `felhasznalo` (`id`,`nev`,`szuletesidatum`,`profilkepnev`) VALUES (NULL, @nev, @szuletesidatum, @profilkepnev)";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nev", nevtxt.Text);
            sqlCommand.Parameters.AddWithValue("@szuletesidatum", datum.Value.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@profilkepnev", profiltxt.Text);
            conn.Open();
            try
            {
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeres volt az adatok rögzítése!!!!");
                    idtxt.Text = "";
                    nevtxt.Text = "";
                    datum.ResetText();
                    profiltxt.Text = "";
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("Sikertelen volt az adatok rögzítése!!!!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Sikertelen!!!!");
            }
            conn.Close();
            felhasznalonevbetolt();
        }

        private bool nincs_adat()
        {
            if (string.IsNullOrEmpty(nevtxt.Text))
            {
                MessageBox.Show("Nem adaott meg nevet!!!");
                nevtxt.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(profiltxt.Text))
            {
                MessageBox.Show("Nem adta meg a profilkép nevét!!!!");
                profiltxt.Focus();
                return true;
            }
            return false;
        }
        private void _profil_feltolt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.png|*.png|*.jpg|*.jpg|*.jfif|*.jfif|*.webp|*.webp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string kepFajl = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(kepFajl);
            }
        }

        private void editb_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex < 0)
            {
                return;
            }
            adat kivalasztottfelhasznalo = (adat)lista.SelectedItem;
            sqlCommand.CommandText = "UPDATE `felhasznalo` SET `nev` = @nev, `szuletesidatum` = @szuletesidatum, `profilkepnev`= @profilkepnev WHERE `id` = @id";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id", idtxt.Text);
            sqlCommand.Parameters.AddWithValue("@nev", nevtxt.Text);
            sqlCommand.Parameters.AddWithValue("@szuletesidatum", datum.Value.ToString("yyyy-MM-dd"));
            conn.Open();

            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Az adatok módosítása sikeres volt!!!!");
                conn.Close();
                idtxt.Text = "";
                nevtxt.Text = "";
                datum.ResetText();
                profiltxt.Text = "";
                pictureBox1.Image = null;
                felhasznalonevbetolt();
            }
            else
            {
                MessageBox.Show("Az adatok törlése sikertelen volt!!!!!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex < 0)
            {
                return;
            }
            sqlCommand.CommandText = "DELETE FROM `felhasznalo` WHERE `id` = @id;";
            sqlCommand.Parameters.AddWithValue("@id", idtxt.Text);
            conn.Open();

            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Az adatok törlése sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
                idtxt.Text = "";
                nevtxt.Text = "";
                datum.ResetText();
                profiltxt.Text = "";
                felhasznalonevbetolt();
            }
            else
            {
                MessageBox.Show("Az adatok törlése sikertelen volt!!!!!!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
