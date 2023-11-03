using LiftSystemApp.Views;
using System.Windows.Forms;

namespace LiftSystemApp
{
    public partial class LiftFloors : Form
    {
        public LiftFloors()
        {
            InitializeComponent();
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

        public Floor1 GetFloor1 => userControl11;
        public Floor2 GetFloor2 => userControl12;

    }
}