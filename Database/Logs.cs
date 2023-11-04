namespace LiftSystemApp.Database
{
    public class Logs
    {
        private int id;
        private string message;
        private string created;

        public Logs(int id, string message, string created)
        {
            this.id = id;
            this.message = message;
            this.created = created;
        }

        public Logs(string message)
        {
            this.message = message;
        }

        public int Id => id;

        public string Message => message;

        public string Created => created;
    }
}