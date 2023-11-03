using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace LiftSystemApp
{
    public abstract partial class MainDesign : UserControl
    {
        private bool _doorClose = true;
        public MainDesign()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        public void openDoor(
            )
        {
            if (!_doorClose) return;

            Timer doorTimer = new Timer();
            doorTimer.Interval = 70;
            doorTimer.Tick += (s, args) =>
            {
                if (leftDoor.Width <= 0 && rightDoor.Width <= 0)
                {
                    doorTimer.Stop();
                    _doorClose = false;

                }
                else
                {
                    if (leftDoor.Width > 0)
                    {
                        leftDoor.Width -= 5;
                    }
                    if (rightDoor.Width > 0)
                    {
                        rightDoor.Width -= 5;
                        rightDoor.Left += 5;
                    }
                }
            };
            doorTimer.Start();

        }

        public void CloseDoor()
        {
            if (_doorClose) return;
            var originalDoorWidth = 163;
            Timer doorTimer = new Timer();
            doorTimer.Interval = 70;
            doorTimer.Tick += (s, args) =>
            {
                if (leftDoor.Width >= originalDoorWidth && rightDoor.Width >= originalDoorWidth)
                {
                    doorTimer.Stop();
                    _doorClose = true;

                }
                else
                {
                    if (leftDoor.Width < originalDoorWidth)
                    {
                        leftDoor.Width += 5;
                    }
                    if (rightDoor.Width < originalDoorWidth)
                    {
                        rightDoor.Width += 5;
                        rightDoor.Left -= 5;
                    }
                }
            };
            doorTimer.Start();
        }





        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void rightForm_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        public event EventHandler ButtonClick;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void rightDoor_Click(object sender, EventArgs e)
        {

        }

        public abstract int GetFloorNumber();

        private void indicator_Click(object sender, EventArgs e)
        {

        }

        private void liftCart_Click(object sender, EventArgs e)
        {

        }

        public bool IsDoorClose => _doorClose;
    }
}
