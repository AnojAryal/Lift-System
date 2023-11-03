using LiftSystemApp.Enum;

namespace LiftSystemApp.Helper
{
    public static class LiftState
    {
        private static MainDesign? currentFloor;
        private static LiftDirection direction;
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
