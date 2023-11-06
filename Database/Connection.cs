using MySqlConnector;

namespace LiftSystemApp.Database
{
    public class Connection
    {
        private MySqlConnection conn = null;
        private string url = "datasource=localhost; database=LiftSystem; port=3306; User=root; Password=fastrack";
        public MySqlConnection Connect()
        {
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return conn;
        }
        public bool Close(MySqlConnection conn)
        {
            bool result = false;
            try
            {
                conn.Close();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }
}