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
    /// Tests for MC class methods
    /// </summary>
    [TestClass()]
    public class MCTests
    {
        /// <summary>
        /// Test with no Brobizz
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {

            //Arrange
            MC mc = new MC();
            Brobizz brobizz = new Brobizz(false);

            //Act
            var result = mc.Price(brobizz);

            //Assert
            Assert.AreEqual(125, result);

        }
        
        /// <summary>
        /// Test to check vehicle type for MC
        /// </summary>
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

        /// <summary>
        /// Test with Brobizz discount
        /// </summary>
        [TestMethod()]
        public void PriceTest1()
        {
            //Arrange
            MC mc = new MC();
            Brobizz brobizz = new Brobizz(true);

            //Act
            var result = mc.Price(brobizz);

            //Assert
            Assert.AreEqual(118.75, result);
        }
    }
}