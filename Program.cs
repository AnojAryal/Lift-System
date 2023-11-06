using System;
using System.Windows.Forms;
using LiftSystemApp.Database;
using LiftSystemApp.Middleware;

namespace LiftSystemApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize application-wide settings and configurations
            ApplicationConfiguration.Initialize();

            // Create the main form
            var form = new LiftFloors();

            // Establish a database connection
            var connection = new Connection();
            var databaseConnection = connection.Connect();

            // Create DataAccess with the database connection
            var dataAccess = new DataAccess(databaseConnection);

            // Create and initialize the Manager with the form, DataAccess, and database connection
            var manager = new Manager(form, dataAccess, databaseConnection);

            // Run the application
            Application.Run(form);
        }
    }
}
