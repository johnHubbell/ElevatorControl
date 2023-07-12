using ElevatorControl.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static ElevatorControl.Model.Enums;

namespace ElevatorControl.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElevatorController : ControllerBase
    {
        private readonly IElevator _elevator;

        public ElevatorController(IElevator elevator)
        {
            _elevator = elevator;
        }

        /// <summary>
        /// Add new Destination that can be from a person in the Elevaror Car or
        /// out of elevaror car are in the floors
        /// </summary>
        /// <param name="floorNumber"></param>
        [HttpPost(Name = "AddDestination")]
        public void AddDestination([FromBody] int floorNumber)
        {
            _elevator.AddNewDestination(floorNumber);
        }

        /// <summary>
        /// Return the current floor of Elevaror Car
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetCurrentFloor")]
        public int GetCurrentFloor()
        {
            return _elevator.GetCurrentFloor();
        }

        /// <summary>
        /// Return the direction of elevaror 
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetElevatorDirection")]
        public ElevatorDirection GetElevatorDirection()
        {
            return _elevator.GetDirection();
        }

        /// <summary>
        /// Return the floor number of next destination of elevaror
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetNextDestionationFloor")]
        public int GetNextDestionationFloor()
        {
            return _elevator.GetNextDestionationFloor();
        }

        /// <summary>
        /// Return the totall number of requested that send to elevator system 
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetTotalRequests")]
        public int GetTotalRequests()
        {
            return _elevator.GetTotalRequests();
        }

        /// <summary>
        /// The Elevaror give an instruction to the system to move to next destination
        /// </summary>
        /// <returns></returns>
        public bool MoveAndCheckIfServed()
        {
            return _elevator.MoveAndCheckIfServed();
        }
    }
}