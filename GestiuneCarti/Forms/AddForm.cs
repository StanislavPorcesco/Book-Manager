using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using System.Data.SQLite;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Globalization;
using System.Text.RegularExpressions;

namespace GestiuneCarti.Forms
{
    public partial class AddForm : Form
    {
        private SQLiteConnection connection;
        public AddForm(SQLiteConnection conn)
        {
            connection = conn ?? throw new ArgumentNullException(nameof(conn));
            InitializeComponent();
        }

        public void AddForm_Load(object sender, EventArgs e)
        {

        }

        //EVENT HANDLERS
        private void adaugaCarte_btn_Click(object sender, EventArgs e)
        {
            int id_carte;
            int id_vechi;
            string titlu = string.Empty;
            string autor = string.Empty;
            int anul_pub;
            string locul_pub = string.Empty;
            string id_czu = string.Empty;
            decimal pret;
            if (connection.State != ConnectionState.Open) { connection.Open(); }
            try
            {
                //Exceptii
                if (idCarte_tb.Text == string.Empty || !idCarte_tb.Text.All(char.IsDigit))
                {
                    throw new Exception("ID Carte invalid!");
                }
                else id_carte = Convert.ToInt32(idCarte_tb.Text);

                if (idVechi_tb.Text == string.Empty || !idVechi_tb.Text.All(char.IsDigit))
                {
                    throw new Exception("ID Vechi invalid!");
                }
                else id_vechi = Convert.ToInt32(idCarte_tb.Text);

                if (titlu_tb.Text == string.Empty || titlu_tb.Text.Length < 2)
                {
                    throw new Exception("Titlu invalid!");
                }
                else titlu = titlu_tb.Text;

                if (autor_tb.Text == string.Empty || titlu_tb.Text.Length < 3)
                {
                    throw new Exception("Autor invalid!");
                }
                else autor = autor_tb.Text;

                if (anPublicare_tb.Text == string.Empty || !anPublicare_tb.Text.All(char.IsDigit) || anPublicare_tb.Text.Length != 4)
                {
                    throw new Exception("An publicare invalid!");
                }
                else anul_pub = Convert.ToInt32(anPublicare_tb.Text);

                if (locPublicare_tb.Text == string.Empty || locPublicare_tb.Text.Length < 3)
                {
                    throw new Exception("Loc publicare invalid!");
                }
                else locul_pub = locPublicare_tb.Text;

                if (idCZU_tb.Text == string.Empty)
                {
                    throw new Exception("ID Czu invalid!");
                }
                else id_czu = idCZU_tb.Text;

                if (pret_tb.Text == string.Empty || !Regex.IsMatch(pret_tb.Text, @"^\d{1,5}([.]\d{1,2})?$"))
                {
                    throw new Exception("Preț invalid!\n(Ex: 99.99)");
                }
                else pret = decimal.Parse(pret_tb.Text, CultureInfo.InvariantCulture);

                Carte carte = new Carte(id_carte, id_vechi, titlu, autor, locul_pub, anul_pub, id_czu, pret);
                Data.adaugaCarte(connection, carte);

                MessageBox.Show("Carte adăugată cu succes!");
            }
            catch (Exception ex) { MessageBox.Show("Eroare: " + ex.Message); }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}