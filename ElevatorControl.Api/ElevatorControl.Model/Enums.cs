namespace ElevatorControl.Model
{
    public class Enums
    {
        public enum ElevatorDirection
        {
            /// <summary>
            /// Elevator is moving UP.
            /// </summary>
            Elevator_Up = 1,

            /// <summary>
            /// Elevator is moving DOWN.
            /// </summary>
            Elevator_Down = 2,

            /// <summary>
            /// Elevator was in NONE state which means elevator hasn't serviced any request.
            /// </summary>
            Elevator_None = 3
        }
    }
}
