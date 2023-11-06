using MySqlConnector;
using System.Data;

namespace LiftSystemApp.Database
{
    public class DataAccess
    {
        private MySqlConnection conn;

        public DataAccess(MySqlConnection connection)
        {
            conn = connection;
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable resultTable = new DataTable();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultTable;
        }

        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return rowsAffected;
        }
    }
}
