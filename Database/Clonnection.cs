using MySqlConnector;
using System.Data;

namespace LiftSystemApp.Database
{
    public class ElevatorLogRepository
    {
        private readonly string connectionString;

        public ElevatorLogRepository(string databaseConnectionString)
        {
            connectionString = databaseConnectionString;
        }

        public void InsertLog(string action, string description)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO elevator_logs (timestamp, action, description) VALUES (@timestamp, @action, @description)";
                    cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                    cmd.Parameters.AddWithValue("@action", action);
                    cmd.Parameters.AddWithValue("@description", description);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetLogs()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM elevator_logs";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}
