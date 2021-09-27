using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketSystem.Tests
{
    /// <summary>
    /// Tests for Oresund Car class methods
    /// </summary>
    [TestClass()]
    public class OresundCarTests
    {
        /// <summary>
        /// Test with no Brobizz
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            OresundCar car = new OresundCar();
            Brobizz brobizz = new Brobizz(false);

            //Act
            var result = car.Price(brobizz);

            //Assert
            Assert.AreEqual(410, result);

        }

        /// <summary>
        /// Method to test the type of the vehicle
        /// </summary>
        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            OresundCar car = new OresundCar();

            //Act
            var result = car.VehicleType();

            //Assert
            Assert.AreEqual("Oresund car", result);

        }

        /// <summary>
        /// Test with Brobizz discount
        /// </summary>
        [TestMethod()]
        public void PriceTest1()
        {
            //Arrange
            OresundCar car = new OresundCar();
            Brobizz brobizz = new Brobizz(true);

            //Act
            var result = car.Price(brobizz);

            //Assert
            Assert.AreEqual(161, result);
        }
    }
}