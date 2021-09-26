using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    /// <summary>
    /// Tests for Car class methods
    /// </summary>
    [TestClass()]
    public class CarTests
    {
        /// <summary>
        /// Test with no Brobizz
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            Car car = new Car();
            Brobizz brobizz = new Brobizz(false);

            //Act
            var result = car.Price(brobizz);

            //Assert
            Assert.AreEqual(240, result);

        }

        /// <summary>
        /// Method to test the type of the vehicle
        /// </summary>
        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            Car car = new Car();

            //Act
            var result = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", result);

        }

        /// <summary>
        /// Test with Brobizz discount
        /// </summary>
        [TestMethod()]
        public void PriceTest1()
        {
            //Arrange
            Car car = new Car();
            Brobizz brobizz = new Brobizz(true);

            //Act
            var result = car.Price(brobizz);

            //Assert
            Assert.AreEqual(228, result);
        }
    }
}