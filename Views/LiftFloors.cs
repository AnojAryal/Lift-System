using LiftSystemApp.Database;
using LiftSystemApp.Views;
using MySqlConnector;
using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace LiftSystemApp
{
    public partial class LiftFloors : Form
    {
        private readonly DataAccess dataAcess;
        private readonly MySqlConnection connection;
        private Timer timer;
        public LiftFloors()
        {
            InitializeComponent();
            var connection = new Connection();
            var databaseConnection = connection.Connect();
            dataAcess = new DataAccess(databaseConnection);
            timer = new Timer();
            timer.Interval = 2000; // Set the refresh interval (5 seconds in this example).
            timer.Tick += Timer_Tick;
            timer.Start();

            // Initial log update.
            UpdateLogListBox();
        }

        private void UpdateLogListBox()
        {
            string query = "SELECT Message, created FROM logs ORDER BY created DESC"; // Replace with your SQL query
            DataTable dataTable = dataAcess.ExecuteQuery(query);

            logsDisplay.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                logsDisplay.Items.Add(row["Message"].ToString());
                logsDisplay.Items.Add(row["created"].ToString());
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Timer tick event handler; this is called at the specified interval.
            UpdateLogListBox();
        }


        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl12_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void logsButton_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Floor1 GetFloor1 => userControl11;
        public Floor2 GetFloor2 => userControl12;

    }
}