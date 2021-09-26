using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            Car car = new Car();

            //Act
            var result = car.Price();

            //Assert
            Assert.AreEqual(240, result);

        }

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
              
    }
}