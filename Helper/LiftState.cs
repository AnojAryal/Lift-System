using LiftSystemApp.Enum;

namespace LiftSystemApp.Helper
{
    public static class LiftState
    {
        // Store the current floor 
        private static MainDesign? currentFloor;

        // Store the direction in which the elevator is moving (Up or Down).
        private static LiftDirection direction;

        // Store the status of the elevator (Stopped, Moving, etc.).
        private static LiftStatus status;

      
        public static MainDesign CurrentFloor
        {
            set => currentFloor = value;
            get => currentFloor;
        }

        public static LiftDirection Direction
        {
            set => direction = value;
            get => direction;
        }

        public static LiftStatus Status
        {
            set => status = value;
            get => status;
        }
    }
}
