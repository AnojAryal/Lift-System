using LiftSystemApp.Database;
using LiftSystemApp.Enum;
using LiftSystemApp.Helper;
using MySqlConnector;

namespace LiftSystemApp.Middleware
{
    public class Manager
    {
        private MainDesign[] controls = new MainDesign[2];
        private bool isMoving = false;
        private readonly DataAccess dataAcess;
        private readonly MySqlConnection connection;

        public Manager(LiftFloors form1, DataAccess dataAccess, MySqlConnection databaseConnection)
        {
            // Initialize the controls array with floor controls from form1
            this.controls[0] = form1.GetFloor1;
            this.controls[1] = form1.GetFloor2;

            // Store the dataAccess and databaseConnection parameters
            this.dataAcess = dataAccess ?? throw new ArgumentNullException(nameof(dataAccess));
            this.connection = databaseConnection ?? throw new ArgumentNullException(nameof(databaseConnection));

            // Event handlers for button clicks on both floor controls
            foreach (var item in controls)
            {
                var floor = item as MainDesign;

                // Event handler for the "Up" button click
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

                // Event handler for the "Floor 1" button click
                floor.Floor1Button.Click += async (object sender, EventArgs e) =>
                {
                    await MoveLiftDown();
                };

                // Event handler for the "Floor 2" button click
                floor.Floor2Button.Click += async (object sender, EventArgs e) =>
                {
                    await MoveLiftUp();
                };

                // Initialize the initial elevator state
                InitializeElevatorState();
            }
        }

        // Initialize the elevator state
        private void InitializeElevatorState()
        {
            LiftState.CurrentFloor = controls[0];
            LiftState.Status = LiftStatus.Stopped;
            LiftState.Direction = LiftDirection.Up;
        }

        // Method to move the elevator up
        private async Task MoveLiftUp()
        {
            if (!LiftState.CurrentFloor.IsDoorClose)
            {
                LiftState.CurrentFloor.CloseDoor();
            }

            LiftState.Status = LiftStatus.Moving;
            dataAcess.ExecuteQuery("INSERT INTO logs (message) VALUES ('Elevator requested on second floor.')");
            LiftState.Direction = LiftDirection.Up;

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_up;
            }

            await Task.Delay(4000);

            LiftState.CurrentFloor = controls[1];
            LiftState.Status = LiftStatus.Stopped;
            dataAcess.ExecuteQuery("INSERT INTO logs (message) VALUES ('Elevator Moving up to second floor.')");

            await Task.Delay(1000);

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_f2;
            }

            LiftState.CurrentFloor.openDoor();
            dataAcess.ExecuteQuery("INSERT INTO logs (message) VALUES ('Elevator Reached to second floor.')");

            await Task.Delay(5000);
            LiftState.CurrentFloor.CloseDoor();
        }

        // Method to move the elevator down
        private async Task MoveLiftDown()
        {
            if (!LiftState.CurrentFloor.IsDoorClose)
            {
                LiftState.CurrentFloor.CloseDoor();
            }

            LiftState.Status = LiftStatus.Moving;
            dataAcess.ExecuteQuery("INSERT INTO logs (message) VALUES ('Elevator requested on first floor.')");
            LiftState.Direction = LiftDirection.Down;

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_down;
            }

            await Task.Delay(3000);
            dataAcess.ExecuteQuery("INSERT INTO logs (message) VALUES ('Elevator Moving down to first floor.')");

            LiftState.CurrentFloor = controls[0];
            LiftState.Status = LiftStatus.Stopped;

            await Task.Delay(1000);

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_floor1;
            }

            LiftState.CurrentFloor.openDoor();
            dataAcess.ExecuteQuery("INSERT INTO logs (message) VALUES ('Elevator Reached to first floor.')");

            await Task.Delay(5000);
            LiftState.CurrentFloor.CloseDoor();
        }
    }
}
