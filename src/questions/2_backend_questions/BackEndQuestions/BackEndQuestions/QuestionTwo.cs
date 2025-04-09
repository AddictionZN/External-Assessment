using System;
using System.Collections.Generic;

namespace Manufacturing
{
    #region Service Interfaces

    /// <summary>
    /// Represents a service for building robots.
    /// </summary>
    public interface IRobotService
    {
        /// <summary>
        /// Builds a robot of the specified type using the provided parts.
        /// </summary>
        /// <param name="robotType">The type of robot to build.</param>
        /// <param name="parts">The parts required for building the robot.</param>
        /// <returns>A <see cref="Robot"/> instance.</returns>
        Robot BuildRobot(RobotType robotType, List<Part> parts);
    }

    /// <summary>
    /// Represents a service for building cars.
    /// </summary>
    public interface ICarService
    {
        /// <summary>
        /// Builds a car of the specified type using the provided parts.
        /// </summary>
        /// <param name="carType">The type of car to build.</param>
        /// <param name="parts">The parts required for building the car.</param>
        /// <returns>A <see cref="Car"/> instance.</returns>
        Car BuildCar(CarType carType, List<Part> parts);
    }

    /// <summary>
    /// Represents a service for retrieving parts.
    /// </summary>
    public interface IPartsService
    {
        /// <summary>
        /// Gets the required parts for the specified item type.
        /// </summary>
        /// <param name="itemType">An enumerated type representing the item.</param>
        /// <returns>A list of parts.</returns>
        List<Part> GetParts(Enum itemType);
    }

    #endregion

    #region Domain Types

    /// <summary>
    /// Enumerates the types of robots available.
    /// </summary>
    public enum RobotType
    {
        RoboticDog,
        RoboticCat,
        RoboticDrone,
        RoboticCar
    }

    /// <summary>
    /// Enumerates the types of cars available.
    /// </summary>
    public enum CarType
    {
        Toyota,
        Ford,
        Opel,
        Honda
    }

    /// <summary>
    /// Represents a generic robot.
    /// </summary>
    public class Robot
    {
        // Assume implementation details here.
    }

    /// <summary>
    /// Represents a generic car.
    /// </summary>
    public class Car
    {
        // Assume implementation details here.
    }

    /// <summary>
    /// Represents a part used in manufacturing robots or cars.
    /// </summary>
    public class Part
    {
        // Assume implementation details here.
    }

    #endregion

    /// <summary>
    /// Provides factory methods for creating robots and cars.
    /// </summary>
    public class Factory
    {
        private readonly IRobotService robotService;
        private readonly ICarService carService;
        private readonly IPartsService partsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="Factory"/> class.
        /// </summary>
        /// <param name="robotService">The robot service implementation.</param>
        /// <param name="carService">The car service implementation.</param>
        /// <param name="partsService">The parts service implementation.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when any of the service dependencies are null.
        /// </exception>
        public Factory(IRobotService robotService, ICarService carService, IPartsService partsService)
        {
            this.robotService = robotService ?? throw new ArgumentNullException(nameof(robotService));
            this.carService = carService ?? throw new ArgumentNullException(nameof(carService));
            this.partsService = partsService ?? throw new ArgumentNullException(nameof(partsService));
        }

        /// <summary>
        /// Builds a robot using the provided <see cref="RobotType"/>.
        /// </summary>
        /// <param name="robotType">The type of robot to build.</param>
        /// <returns>A <see cref="Robot"/> instance, or <c>null</c> if the robot type is unsupported.</returns>
        public Robot BuildRobot(RobotType robotType)
        {
            // Retrieve parts specific for the robot type.
            var parts = partsService.GetParts(robotType);
            // Delegate the building to the injected service.
            return robotService.BuildRobot(robotType, parts);
        }

        /// <summary>
        /// Builds a car using the provided <see cref="CarType"/>.
        /// </summary>
        /// <param name="carType">The type of car to build.</param>
        /// <returns>A <see cref="Car"/> instance, or <c>null</c> if the car type is unsupported.</returns>
        public Car BuildCar(CarType carType)
        {
            // Retrieve parts specific for the car type.
            var parts = partsService.GetParts(carType);
            // Delegate the building to the injected service.
            return carService.BuildCar(carType, parts);
        }
    }
}
