using System;
using System.Collections.Generic;
using Manufacturing;
using Moq;
using Xunit;

namespace Manufacturing.Tests
{
    /// <summary>
    /// Contains unit tests for the Factory class.
    /// </summary>
    public class FactoryTests
    {
        /// <summary>
        /// Tests that BuildRobot returns a Robot when a valid RobotType is provided.
        /// </summary>
        [Fact]
        public void BuildRobot_WithValidRobotType_ReturnsRobot()
        {
            // Arrange
            var robotType = RobotType.RoboticDog;
            var expectedParts = new List<Part> { new Part(), new Part() }; // dummy parts list
            var expectedRobot = new Robot();

            var mockRobotService = new Mock<IRobotService>();
            var mockPartsService = new Mock<IPartsService>();
            var mockCarService = new Mock<ICarService>(); // Unused in this test

            // Setup parts service to return expected parts for the robot type.
            mockPartsService.Setup(ps => ps.GetParts(robotType))
                            .Returns(expectedParts);
            // Setup robot service to return the expected robot when called.
            mockRobotService.Setup(rs => rs.BuildRobot(robotType, expectedParts))
                            .Returns(expectedRobot);

            // Act
            var factory = new Factory(mockRobotService.Object, mockCarService.Object, mockPartsService.Object);
            var actualRobot = factory.BuildRobot(robotType);

            // Assert
            Assert.NotNull(actualRobot);
            Assert.Equal(expectedRobot, actualRobot);

            // Verify that the GetParts and BuildRobot methods were called exactly once.
            mockPartsService.Verify(ps => ps.GetParts(robotType), Times.Once);
            mockRobotService.Verify(rs => rs.BuildRobot(robotType, expectedParts), Times.Once);
        }

        /// <summary>
        /// Tests that BuildCar returns a Car when a valid CarType is provided.
        /// </summary>
        [Fact]
        public void BuildCar_WithValidCarType_ReturnsCar()
        {
            // Arrange
            var carType = CarType.Ford;
            var expectedParts = new List<Part> { new Part(), new Part(), new Part() }; // dummy parts list
            var expectedCar = new Car();

            var mockCarService = new Mock<ICarService>();
            var mockPartsService = new Mock<IPartsService>();
            var mockRobotService = new Mock<IRobotService>(); // Unused in this test

            // Setup parts service to return expected parts for the car type.
            mockPartsService.Setup(ps => ps.GetParts(carType))
                            .Returns(expectedParts);
            // Setup car service to return the expected car when called.
            mockCarService.Setup(cs => cs.BuildCar(carType, expectedParts))
                          .Returns(expectedCar);

            // Act
            var factory = new Factory(mockRobotService.Object, mockCarService.Object, mockPartsService.Object);
            var actualCar = factory.BuildCar(carType);

            // Assert
            Assert.NotNull(actualCar);
            Assert.Equal(expectedCar, actualCar);

            // Verify that the GetParts and BuildCar methods were called exactly once.
            mockPartsService.Verify(ps => ps.GetParts(carType), Times.Once);
            mockCarService.Verify(cs => cs.BuildCar(carType, expectedParts), Times.Once);
        }

        /// <summary>
        /// Tests that the Factory constructor throws an ArgumentNullException when a null IRobotService is provided.
        /// </summary>
        [Fact]
        public void Constructor_WithNullRobotService_ThrowsArgumentNullException()
        {
            // Arrange
            IRobotService robotService = null;
            var mockCarService = new Mock<ICarService>();
            var mockPartsService = new Mock<IPartsService>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() =>
                new Factory(robotService, mockCarService.Object, mockPartsService.Object));
        }

        /// <summary>
        /// Tests that the Factory constructor throws an ArgumentNullException when a null ICarService is provided.
        /// </summary>
        [Fact]
        public void Constructor_WithNullCarService_ThrowsArgumentNullException()
        {
            // Arrange
            var mockRobotService = new Mock<IRobotService>();
            ICarService carService = null;
            var mockPartsService = new Mock<IPartsService>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() =>
                new Factory(mockRobotService.Object, carService, mockPartsService.Object));
        }

        /// <summary>
        /// Tests that the Factory constructor throws an ArgumentNullException when a null IPartsService is provided.
        /// </summary>
        [Fact]
        public void Constructor_WithNullPartsService_ThrowsArgumentNullException()
        {
            // Arrange
            var mockRobotService = new Mock<IRobotService>();
            var mockCarService = new Mock<ICarService>();
            IPartsService partsService = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() =>
                new Factory(mockRobotService.Object, mockCarService.Object, partsService));
        }
    }
}
