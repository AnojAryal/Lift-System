using MySqlConnector;
using System.Data;

namespace LiftSystemApp.Database
{
    public class DataAccess
    {
        private MySqlConnection conn;

        public DataAccess(MySqlConnection connection)
        {
            // Initialize the DataAccess class with a MySqlConnection object.
            conn = connection;
        }

        public DataTable ExecuteQuery(string query)
        {
            // Create a DataTable to store query results.
            DataTable resultTable = new DataTable();

            try
            {
                // Check if the database connection is not open, and if not, open it.
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                // Create a MySqlCommand object with the provided SQL query.
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Use a MySqlDataAdapter to execute the query and fill the result into the DataTable.
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the execution of the query.
                Console.WriteLine(ex.ToString());
            }

            // Return the DataTable containing the query result.
            return resultTable;
        }

        public int ExecuteNonQuery(string query)
        {
            // Initialize the variable to store the number of rows affected by the query.
            int rowsAffected = 0;

            try
            {
                // Check if the database connection is not open, and if not, open it.
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                // Create a MySqlCommand object with the provided SQL query.
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Execute the query and get the number of rows affected.
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the execution of the query.
                Console.WriteLine(ex.ToString());
            }

            // Return the number of rows affected by the query.
            return rowsAffected;
        }
    }
}
