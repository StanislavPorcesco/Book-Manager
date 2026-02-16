using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Oracle.ManagedDataAccess.Client;
using System.Xml;
using static System.Windows.Forms.Design.AxImporter;

namespace GestiuneCarti.Forms
{
    public partial class ModifyForm : Form
    {
        private SQLiteConnection connection;
        public ModifyForm(SQLiteConnection conn)
        {
            connection = conn ?? throw new ArgumentNullException(nameof(conn));
            InitializeComponent();
            populareListaOptiuni();
        }
        public void populareListaOptiuni()
        {
            optiune_cb.Items.Clear();
            optiune_cb.Items.AddRange(new object[] { 
                "TITLU", "AUTOR", "LOCUL_PUBLICARII", "ANUL_PUBLICARII", "ID_CZU", "PRET", "ID_VECHI" 
            });
        }
        private void modificaCarte_btn_Click(object sender, EventArgs e)
        {
            string optiuneSelectata = string.Empty;
            string valoareaNoua = string.Empty;
            int id_carte;

            try
            {
                if(connection.State != ConnectionState.Open) { connection.Open(); }

                if (optiune_cb.Text == string.Empty)
                {
                    throw new Exception("Optiune invalidă!");
                } else optiuneSelectata = optiune_cb.Text;

                if (idCarte_tb.Text == string.Empty)
                {
                    throw new Exception("ID Carte invalid!");
                } else id_carte = Convert.ToInt32(idCarte_tb.Text);

                if (valoare_tb.Text == string.Empty)
                {
                    throw new Exception("Valoare imvalidă!");
                } else valoareaNoua = valoare_tb.Text;

                switch (optiuneSelectata)
                {
                    case "TITLU":
                        using (var cmd = new SQLiteCommand("UPDATE Carti SET TITLU = @valoare WHERE ID_CARTE = @id_carte", connection))
                        {
                            cmd.Parameters.AddWithValue("@valoare", valoareaNoua);
                            cmd.Parameters.AddWithValue("@id_carte", id_carte);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "AUTOR":
                        using (var cmd = new SQLiteCommand("UPDATE Carti SET AUTOR = @valoare WHERE ID_CARTE = @id_carte", connection))
                        {
                            cmd.Parameters.AddWithValue("@valoare", valoareaNoua);
                            cmd.Parameters.AddWithValue("@id_carte", id_carte);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "LOCUL_PUBLICARII":
                        using (var cmd = new SQLiteCommand("UPDATE Carti SET LOCUL_PUBLICARII = @valoare WHERE ID_CARTE = @id_carte", connection))
                        {
                            cmd.Parameters.AddWithValue("@valoare", valoareaNoua);
                            cmd.Parameters.AddWithValue("@id_carte", id_carte);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "ANUL_PUBLICARII":
                        using (var cmd = new SQLiteCommand("UPDATE Carti SET ANUL_PUBLICARII = @valoare WHERE ID_CARTE = @id_carte", connection))
                        {
                            cmd.Parameters.AddWithValue("@valoare", Convert.ToInt32(valoareaNoua));
                            cmd.Parameters.AddWithValue("@id_carte", id_carte);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "ID_CZU":
                        using (var cmd = new SQLiteCommand("UPDATE Carti SET ID_CZU = @valoare WHERE ID_CARTE = @id_carte", connection))
                        {
                            cmd.Parameters.AddWithValue("@valoare", valoareaNoua);
                            cmd.Parameters.AddWithValue("@id_carte", id_carte);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "PRET":
                        using (var cmd = new SQLiteCommand("UPDATE Carti SET PRET = @valoare WHERE ID_CARTE = @id_carte", connection))
                        {
                            cmd.Parameters.AddWithValue("@valoare", decimal.Parse(valoareaNoua, CultureInfo.InvariantCulture));
                            cmd.Parameters.AddWithValue("@id_carte", id_carte);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "ID_VECHI":
                        using (var cmd = new SQLiteCommand("UPDATE Carti SET ID_VECHI = @valoare WHERE ID_CARTE = @id_carte", connection))
                        {
                            cmd.Parameters.AddWithValue("@valoare", valoareaNoua);
                            cmd.Parameters.AddWithValue("@id_carte", id_carte);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                }
                MessageBox.Show("Ați modificat cu succes!");
            }
            catch (Exception ex) { MessageBox.Show("Eroare: " + ex.Message);}
             
        }
    }
}
