using LiftSystemApp.Helper;
using LiftSystemApp.Views;
using System;
using System.Threading.Tasks;


namespace LiftSystemApp.Middleware
{
    public class manager
    {
        private MainDesign[] controls = new MainDesign[2];
        private bool isMoving = false;
        

        public manager(LiftFloors form1)
        {
            this.controls[0] = form1.GetFloor1;
            this.controls[1] = form1.GetFloor2;


            foreach (var item in controls)
            {
                var floor = item as MainDesign;

                floor.UpButton.Click += async (object sender, EventArgs e) =>
                {
                    if (!isMoving)
                    {
                        isMoving = true;

                        if (LiftState.CurrentFloor == floor)
                        {
                            floor.openDoor();
                        }
                        else
                        {
                            if (LiftState.CurrentFloor == controls[0])
                            {
                                await MoveLiftUp();
                            }
                            else
                            {
                                await MoveLiftDown();
                            }
                        }

                        isMoving = false;
                    }
                };

                floor.Floor1Button.Click += async (object sender, EventArgs e) => {
                    await MoveLiftDown();
                };

                floor.Floor2Button.Click += async (object sender, EventArgs e) => {
                    await MoveLiftUp();
                };

                LiftState.CurrentFloor = controls[0];
                LiftState.Status = Enum.LiftStatus.Stopped;
                LiftState.Direction = Enum.LiftDirection.Up;
            }
        }

        private async Task MoveLiftUp()
        {
            if (!LiftState.CurrentFloor.IsDoorClose)
            {
                LiftState.CurrentFloor.CloseDoor();
            }

            LiftState.Status = Enum.LiftStatus.Moving;
            LiftState.Direction = Enum.LiftDirection.Up;

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_up;
            }

            await Task.Delay(3000);

            LiftState.CurrentFloor = controls[1];
            LiftState.Status = Enum.LiftStatus.Stopped;

            await Task.Delay(1000);

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_f2;
            }

            LiftState.CurrentFloor.openDoor();
            await Task.Delay(5000);
            LiftState.CurrentFloor.CloseDoor();
        }

        private async Task MoveLiftDown()
        {
            if (!LiftState.CurrentFloor.IsDoorClose)
            {
                LiftState.CurrentFloor.CloseDoor();
            }

            LiftState.Status = Enum.LiftStatus.Moving;
            LiftState.Direction = Enum.LiftDirection.Down;

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_down;
            }

            await Task.Delay(3000);

            LiftState.CurrentFloor = controls[0];
            LiftState.Status = Enum.LiftStatus.Stopped;

            await Task.Delay(1000);

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_floor1;
            }

            LiftState.CurrentFloor.openDoor();
            await Task.Delay(5000);
            LiftState.CurrentFloor.CloseDoor();
        }
    }
}
