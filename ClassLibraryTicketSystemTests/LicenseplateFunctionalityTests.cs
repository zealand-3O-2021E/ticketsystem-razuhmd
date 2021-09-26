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
    public class LicenseplateFunctionalityTests
    {
        /// <summary>
        /// This test is for a longer than 7 character licenseplate of car.
        /// </summary>
        [TestMethod()]
        public void CheckAndCreateCarTest()
        {
            //Arrange
            string message = null;
            LicenseplateFunctionality numberplate = new LicenseplateFunctionality();

            //Act
            try
            {
                Car car = numberplate.CheckAndCreateCar("CAR12345", DateTime.Now);
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            //Assert
            Assert.AreEqual("Licenseplate is longer than 7 character !!!", message);

        }

        /// <summary>
        /// This test is for 7 character licenseplate of car.
        /// </summary>
        [TestMethod()]
        public void CheckAndCreateCarTest1()
        {
            //Arrange
            string message = null;
            Car car = new Car();
            LicenseplateFunctionality numberplate = new LicenseplateFunctionality();

            //Act
            try
            {
                car = numberplate.CheckAndCreateCar("CAR1234", DateTime.Now);
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            //Assert
            Assert.AreEqual("CAR1234", car.Licenseplate);
        }

        /// <summary>
        ///  This test is for a longer than 7 character licenseplate of MC.
        /// </summary>
        [TestMethod()]
        public void CheckAndCreateMCTest()
        {
            //Arrange
            string message = null;
            LicenseplateFunctionality numberplate = new LicenseplateFunctionality();

            //Act
            try
            {
                MC mc = numberplate.CheckAndCreateMC("MC123456", DateTime.Now);
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            //Assert
            Assert.AreEqual("Licenseplate is longer than 7 character !!!", message);

        }

        /// <summary>
        /// This test is for 7 character licenseplate of MC
        /// </summary>
        [TestMethod()]
        public void CheckAndCreateMCTest1()
        {
            //Arrange
            string message = null;
            MC mc = new MC();
            LicenseplateFunctionality numberplate = new LicenseplateFunctionality();

            //Act
            try
            {
                mc = numberplate.CheckAndCreateMC("MC12345", DateTime.Now);
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            //Assert
            Assert.AreEqual("MC12345", mc.Licenseplate);
        }
    }
}