using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace GestiuneCarti.Forms
{

    public partial class SearchForm : Form
    {
        private SQLiteConnection connection;
        public SearchForm(SQLiteConnection conn)
        {
            connection = conn ?? throw new Exception("Conexiune exuata");
            InitializeComponent();
            populareListaOptiuni();
            afisare_btn_Click(this, EventArgs.Empty);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
        public void populareListaOptiuni()
        {
            coloana_cb.Items.Clear();
            coloana_cb.Items.AddRange(new object[] {
                "ID_CARTE","ID_VECHI","TITLU", "AUTOR", "LOCUL_PUBLICARII", "ANUL_PUBLICARII", "ID_CZU", "PRET"
            });
        }

        private void afisare_btn_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open) connection.Open();
            try
            {
                var dataTable = Data.LoadTable(connection);
                afisare_gv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea tabelei: " + ex.Message);
            }
        }

        private void cauta_btn_Click(object sender, EventArgs e)
        {
            string coloana = string.Empty;
            string valoare = string.Empty;
            if (connection.State != ConnectionState.Open)
                connection.Open();

            try
            {
                if (coloana_cb.Text == string.Empty)
                {
                    throw new Exception("Criteriu invalid!");
                }
                else coloana = coloana_cb.Text;

                if (valoare_tb.Text == string.Empty)
                {
                    throw new Exception("Valore invalidă!");
                }
                if (valoare_tb.Text == "NULL")
                {
                    valoare = "NULL";
                } else valoare = valoare_tb.Text;

                var dataTable = Data.CriteriaLoadTable(connection, valoare, coloana);
                afisare_gv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }
    }
}
