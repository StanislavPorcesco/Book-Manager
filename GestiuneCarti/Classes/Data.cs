using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneCarti
{
    public static class Data
    {
        //CREARE BAZA DE DATE
        public static void createTabelCarti(SQLiteConnection connection)
        {
            if (connection.State != ConnectionState.Open) connection.Open();
            string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Carti (
                    ID_CARTE INTEGER PRIMARY KEY,
                    ID_VECHI INTEGER,
                    TITLU TEXT NOT NULL,
                    AUTOR TEXT NOT NULL,
                    LOCUL_PUBLICARII TEXT NOT NULL,
                    ANUL_PUBLICARII INTEGER NOT NULL,
                    ID_CZU TEXT NOT NULL,
                    PRET DECIMAL(10,2) NOT NULL);";
            using (var cmd = new SQLiteCommand(createTableQuery, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        //METODE PENTRU BAZA DE DATE
        
        public static void adaugaCarte(SQLiteConnection connection, Carte carte)
        {

            using(var cmd = new SQLiteCommand("INSERT INTO Carti VALUES (@id_carte, @id_vechi, @titlu, @autor, @locul_publicarii, @anul_publicarii, @id_czu, @pret)", connection))
            {
                cmd.Parameters.AddWithValue("@id_carte", carte.getIdCarte());
                cmd.Parameters.AddWithValue("@id_vechi", carte.getIdVechi());
                cmd.Parameters.AddWithValue("@titlu", carte.getTitlu());
                cmd.Parameters.AddWithValue("@autor", carte.getAutor());
                cmd.Parameters.AddWithValue("@locul_publicarii", carte.getLoculPublicarii());
                cmd.Parameters.AddWithValue("@anul_publicarii", carte.getAnulPPublicarii());
                cmd.Parameters.AddWithValue("@id_czu", carte.getIdCZU());
                cmd.Parameters.AddWithValue("@pret", Convert.ToDecimal(carte.getPret()));
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable LoadTable(SQLiteConnection conn)
        {
            DataTable table = new DataTable();
            string query = $"SELECT * FROM Carti";

            using (var cmd = new SQLiteCommand(query, conn))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                adapter.Fill(table);
            }

            return table;
        }

        public static DataTable CriteriaLoadTable(SQLiteConnection conn, string valoare, string coloana)
        {
            DataTable table = new DataTable();
            string query = $"SELECT * FROM Carti WHERE {coloana} LIKE '%{valoare}%'";

            using (var cmd = new SQLiteCommand(query, conn))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                adapter.Fill(table);
            }
            return table;
        }

        public static void deleteCarte(SQLiteConnection connection, int idCarte)
        {
            using (var cmd = new SQLiteCommand("DELETE FROM Carti WHERE ID_CARTE = @id_carte", connection))
            {
                cmd.Parameters.AddWithValue("@id_carte", idCarte);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool searchCarteByID(SQLiteConnection connection, int idCarte)
        {
            using (var cmd = new SQLiteCommand("SELECT COUNT(1) FROM Carti WHERE ID_CARTE = @id_carte", connection))
            {
                cmd.Parameters.AddWithValue("@id_carte", idCarte);

                var result = cmd.ExecuteScalar();
                int count = Convert.ToInt32(result);

                return count > 0;
            }
        }
        public static decimal GetTotalPret(SQLiteConnection connection)
        {
            using (var cmd = new SQLiteCommand("SELECT SUM(PRET) FROM Carti", connection))
            {
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
                return 0;
            }
        }

        public static int GetTotalCarti(SQLiteConnection connection)
        {
            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Carti", connection))
            {
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }
    }
}
