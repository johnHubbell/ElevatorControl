using ElevatorControl.Api.Controllers;
using ElevatorControl.Service.Interfaces;
using FakeItEasy;
using FluentAssertions;
using Xunit;
using Xunit.Sdk;
using static ElevatorControl.Model.Enums;

namespace ElevatorControl.Tests.Controller
{
    public class ElevatorControllerTests
    {
        private readonly IElevator _elevator;
        public ElevatorControllerTests()
        {
            _elevator = A.Fake<IElevator>();
        }

        [Fact]
        public void ElevatorController_AddDestination_ReturnOne()
        {
            //Arrange
            A.CallTo(() => _elevator.AddNewDestination(1));
            A.CallTo(() => _elevator.GetTotalRequests()).Returns(1);
            var controller = new ElevatorController(_elevator);

            //Act
            controller.AddDestination(1);
            var result = controller.GetTotalRequests();

            //Assert
            result.Should().BeGreaterThan(0);
            result.Should().Be(1);
        }

        [Fact]
        public void ElevatorController_GetCurrentFloor_ReturnZero()
        {
            //Arrange
            A.CallTo(() => _elevator.GetTotalRequests()).Returns(0);
            var controller = new ElevatorController(_elevator);

            //Act
            var result = controller.GetTotalRequests();

            //Assert
            result.Should().Be(0);
        }

        [Fact]
        public void ElevatorController_GetElevatorDirection_ReturnNone()
        {
            //Arrange
            A.CallTo(() => _elevator.GetDirection()).Returns(ElevatorDirection.Elevator_None);
            var controller = new ElevatorController(_elevator);

            //Act
            var result = controller.GetElevatorDirection();

            //Assert
            result.Should().Be(ElevatorDirection.Elevator_None);
        }

        [Fact]
        public void ElevatorController_GetNextDestionationFloor_ReturnNone()
        {
            //Arrange
            A.CallTo(() => _elevator.GetNextDestionationFloor()).Returns(2);
            var controller = new ElevatorController(_elevator);

            //Act
            var result = controller.GetNextDestionationFloor();

            //Assert
            result.Should().Be(2);
        }

        [Fact]
        public void ElevatorController_GetTotalRequests_ReturnTwo()
        {
            //Arrange
            A.CallTo(() => _elevator.GetTotalRequests()).Returns(2);
            var controller = new ElevatorController(_elevator);

            //Act
            var result = controller.GetTotalRequests();

            //Assert
            result.Should().Be(2);
        }

        [Fact]
        public void ElevatorController_MoveAndCheckIfServed_ReturnTwo()
        {
            //Arrange
            A.CallTo(() => _elevator.MoveAndCheckIfServed()).Returns(false);
            var controller = new ElevatorController(_elevator);

            //Act
            var result = controller.MoveAndCheckIfServed();

            //Assert
            result.Should().Be(false);
        }
    }
}
