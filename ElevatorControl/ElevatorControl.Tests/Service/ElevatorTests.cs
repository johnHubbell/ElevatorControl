using ElevatorControl.Service.Interfaces;
using ElevatorControl.Service.Services;
using FakeItEasy;
using FluentAssertions;

namespace ElevatorControl.Tests.Service
{
    public class ElevatorTests
    {
        private readonly IElevator _elevator;

        public ElevatorTests()
        {
            _elevator = A.Fake<IElevator>();
        }

        [Fact]
        public void Elevator_AddNewDestination_TotalRequest()
        {
            //Arrange
            var elevator = new Elevator();

            //Act
            elevator.AddNewDestination(1);
            var result = elevator.GetTotalRequests();
            //Assert
            result.Should().BeGreaterThan(0);
            result.Should().Be(1);
        }

        [Fact]
        public void Elevator_GetCurrentFloor_ReturnInt()
        {
            //Arrange
            var elevator = new Elevator();

            //Act
            var result = elevator.GetCurrentFloor();

            //Assert
            result.Should().Be(0);
        }

        [Fact]
        public void Elevator_GetDirection_ReturnNone()
        {
            //Arrange
            var elevator = new Elevator();

            //Act
            var result = elevator.GetDirection();

            //Assert
            result.Should().Be(Model.Enums.ElevatorDirection.Elevator_None);
        }

        [Fact]
        public void Elevator_GetTotalRequests_ReturnInt()
        {
            //Arrange
            var elevator = new Elevator();

            //Act
            elevator.AddNewDestination(1);
            elevator.AddNewDestination(2);
            elevator.AddNewDestination(3);
            var result = elevator.GetTotalRequests();

            //Assert
            result.Should().Be(3);
        }

        [Fact]
        public void Elevator_MoveAndCheckIfServed_ReturnFloorNumber()
        {
            //Arrange
            var elevator = new Elevator();

            //Act
            elevator.AddNewDestination(1);
            elevator.AddNewDestination(2);
            elevator.AddNewDestination(3);
            var result1 = elevator.MoveAndCheckIfServed();
            var result2 = elevator.GetCurrentFloor();
            var result3 = elevator.GetNextDestionationFloor();
            

            //Assert
            result1.Should().Be(false);
            result2.Should().Be(1);
            result3.Should().Be(1);
        }

    }
}
