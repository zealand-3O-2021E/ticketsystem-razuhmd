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
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {

            //Arrange
            MC mc = new MC();

            //Act
            var result = mc.Price();

            //Assert
            Assert.AreEqual(125, result);

        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            MC mc = new MC();

            //Act
            var result = mc.VehicleType();

            //Assert
            Assert.AreEqual("MC", result);

        }
    }
}