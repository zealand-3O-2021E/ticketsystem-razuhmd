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
    /// Tests for Oresund MC class methods
    /// </summary>
    [TestClass()]
    public class OresundMCTests
    {
        /// <summary>
        /// Test with no Brobizz
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {

            //Arrange
            OresundMC omc = new OresundMC();
            Brobizz brobizz = new Brobizz(false);

            //Act
            var result = omc.Price(brobizz);

            //Assert
            Assert.AreEqual(210, result);

        }

        /// <summary>
        /// Test to check vehicle type for Oresund MC
        /// </summary>
        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            OresundMC omc = new OresundMC();

            //Act
            var result = omc.VehicleType();

            //Assert
            Assert.AreEqual("Oresund MC", result);

        }

        /// <summary>
        /// Test with Brobizz discount
        /// </summary>
        [TestMethod()]
        public void PriceTest1()
        {
            //Arrange
            OresundMC omc = new OresundMC();
            Brobizz brobizz = new Brobizz(true);

            //Act
            var result = omc.Price(brobizz);

            //Assert
            Assert.AreEqual(73, result);
        }
    }
}