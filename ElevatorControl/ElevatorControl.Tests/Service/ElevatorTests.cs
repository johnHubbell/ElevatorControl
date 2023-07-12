using ElevatorControl.Service.Services;
using FluentAssertions;

namespace ElevatorControl.Tests.Service
{
    public class ElevatorTests
    {
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
    }
}
