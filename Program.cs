using LiftSystemApp.Middleware;

namespace LiftSystemApp
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
          
            ApplicationConfiguration.Initialize();
            var  form = new LiftFloors();
            _ = new manager(form);
            Application.Run(form);
        }
    }
}