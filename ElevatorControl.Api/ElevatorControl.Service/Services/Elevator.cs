using ElevatorControl.Model;
using ElevatorControl.Service.Interfaces;
using Microsoft.Extensions.Options;
using System;
using static ElevatorControl.Model.Enums;

namespace ElevatorControl.Service.Services
{
    /// <summary>
    /// Created by John Hubbell
    /// </summary>
    public class Elevator : IElevator
    {
        private int _currentFloor;

        //Sorted in Asc for up movement
        private List<int> _upDestinationFloors;

        //Sorted in Desc for down movement
        private List<int> _downDestinationFloors;

        ElevatorDirection _direction;

        public Elevator()
        {
            _currentFloor = 0;
            _upDestinationFloors = new List<int>();
            _downDestinationFloors = new List<int>();
            _direction = ElevatorDirection.Elevator_None;
        }

        public void AddNewDestination(int destination)
        {
            if (destination > _currentFloor)
            {
                _upDestinationFloors.Add(destination);
                _upDestinationFloors.Sort();
            }
            else
            {
                _downDestinationFloors.Add(destination);
                _downDestinationFloors.Sort();
                _downDestinationFloors.Reverse();
            }
        }
        public int GetCurrentFloor()
        {
            return _currentFloor;
        }
        public ElevatorDirection GetDirection()
        {
            return _direction;
        }
        public int GetNextDestionationFloor()
        {
            if (_direction == ElevatorDirection.Elevator_Down)
            {
                return this._downDestinationFloors.FirstOrDefault();
            }
            else if (_direction == ElevatorDirection.Elevator_Up)
            {
                return this._upDestinationFloors.FirstOrDefault();
            }
            else
            {
                return 0;
            }
        }
        public int GetTotalRequests()
        {
            return _upDestinationFloors.Count + _downDestinationFloors.Count;
        }
        public bool MoveAndCheckIfServed()
        {
            Direction();
            if (_direction == ElevatorDirection.Elevator_Up)
            {
                if (_upDestinationFloors.FirstOrDefault() == _currentFloor)
                {
                    return PopUpDestionation();
                }
                else
                {
                    _currentFloor++;
                }
            }
            else if (_direction == ElevatorDirection.Elevator_Down)
            {
                if (_downDestinationFloors.FirstOrDefault() == _currentFloor)
                {
                    return PopDownDestionation();
                }
                else
                {
                    _currentFloor--;
                }
            }
            else
            {
                //Do Nothing. Elevator is not moving.
            }
            return false;
        }

        private void Direction()
        {
            if (_direction == ElevatorDirection.Elevator_None)
            {
                if (_upDestinationFloors.Count() > 0 && _downDestinationFloors.Count() > 0)
                {
                    if (Math.Abs(_currentFloor - _upDestinationFloors.FirstOrDefault()) < Math.Abs(_currentFloor - _downDestinationFloors.FirstOrDefault()))
                    {
                        _direction = ElevatorDirection.Elevator_Up;
                    }
                    else
                    {
                        _direction = ElevatorDirection.Elevator_Down;
                    }
                }
                else if (_upDestinationFloors.Count() > 0)
                {
                    _direction = ElevatorDirection.Elevator_Up;
                }
                else if (_downDestinationFloors.Count() > 0)
                {
                    _direction = ElevatorDirection.Elevator_Down;
                }
            }
        }
        private bool PopUpDestionation()
        {
            _upDestinationFloors.Remove(_upDestinationFloors.FirstOrDefault());
            if (_upDestinationFloors.Count() == 0)
            {
                _direction = ElevatorDirection.Elevator_None;
            }
            return true;
        }
        private bool PopDownDestionation()
        {
            _downDestinationFloors.Remove(_downDestinationFloors.FirstOrDefault());
            if (_downDestinationFloors.Count() == 0)
            {
                _direction = ElevatorDirection.Elevator_None;
            }
            return true;
        }
    }
}
