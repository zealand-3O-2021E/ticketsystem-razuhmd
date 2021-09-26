using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class WeekendDiscountForCarTests
    {
        /// <summary>
        /// Test for the method to get the price after weekend and Brobizz discount
        /// </summary>
        [TestMethod()]
        public void GetWeekendBrobizzPriceTest()
        {
            //Arrange
            WeekendDiscountForCar weekendDiscountForCar = new WeekendDiscountForCar(true);

            //Act
            var priceWeekendBrobizz = weekendDiscountForCar.GetWeekendBrobizzPrice();

            //Assert
            Assert.AreEqual(182.4, priceWeekendBrobizz);
        }

        /// <summary>
        /// Test for the method to get the price after only weekend discount
        /// </summary>
        [TestMethod()]
        public void GetWeekendNoBrobizzPriceTest()
        {
            //Arrange
            WeekendDiscountForCar weekendDiscountForCar = new WeekendDiscountForCar(true);

            //Act
            var priceWeekendNoBrobizz = weekendDiscountForCar.GetWeekendNoBrobizzPrice();

            //Assert
            Assert.AreEqual(192, priceWeekendNoBrobizz);

        }
    }
}