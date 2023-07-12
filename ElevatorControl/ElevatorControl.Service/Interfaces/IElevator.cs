using static ElevatorControl.Model.Enums;

namespace ElevatorControl.Service.Interfaces
{
    public interface IElevator
    {
        /// <summary>
        /// Get the next destination floor which will be served by elevator based on pickUp requests.
        /// </summary>
        /// <returns>next destination floor number</returns>
        int GetNextDestionationFloor();

        /// <summary>
        /// get the current floor of elevator
        /// </summary>
        /// <returns>current floor</returns>
        int GetCurrentFloor();

        /// <summary>
        /// Add a new pickUpDestination to elevator
        /// </summary>
        /// <param name="destination"></param>
        void AddNewDestination(int destination);

        /// <summary>
        /// moves the elevator 1 floor at a time based on pickUp request and Elevator Service Algorithm.
        /// </summary>
        /// <returns></returns>
        bool MoveAndCheckIfServed();

        /// <summary>
        /// Get the direction of elevator's movement. Response - Elevator_Up or Elevator_Down or Elevator_None
        /// </summary>
        /// <returns>ElevatorDirection</returns>
        ElevatorDirection GetDirection();

        /// <summary>
        /// Get the total number of pickUpRequests queued for this elevator
        /// </summary>
        /// <returns>Numbers of all requests</returns>
        int GetTotalRequests();
    }
}
