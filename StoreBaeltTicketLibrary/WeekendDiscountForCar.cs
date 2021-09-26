using ClassLibraryTicketSystem;
using System;

namespace StoreBaeltTicketLibrary
{
   /// <summary>
   /// Weekend discount class only for Car 
   /// </summary>
    public class WeekendDiscountForCar
    {
        public bool Weekend { get; set; }

        /// <summary>
        /// Constructor to initialize the property
        /// </summary>
        /// <param name="weekend"></param>
        public WeekendDiscountForCar(bool weekend)
        {
            Weekend = weekend;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public WeekendDiscountForCar()
        {
        }

        /// <summary>
        /// Method to return the price after weekend discount and Brobizz discount
        /// </summary>
        /// <returns></returns>
        public double GetWeekendBrobizzPrice()
        {
            Car car = new Car();
            Brobizz noBrobizz = new Brobizz(false);
            
            var priceNoBrobizz = car.Price(noBrobizz);
            priceNoBrobizz = priceNoBrobizz - priceNoBrobizz * .2;

            var priceWeekendBrobizz = priceNoBrobizz - priceNoBrobizz * .05;

            return priceWeekendBrobizz;
        }

        /// <summary>
        /// Method to return the price after only weekend discount
        /// </summary>
        /// <returns></returns>
        public double GetWeekendNoBrobizzPrice()
        {
            Car car = new Car();
            Brobizz noBrobizz = new Brobizz(false);
            
            var priceWeekendNoBrobizz = car.Price(noBrobizz);
            priceWeekendNoBrobizz = priceWeekendNoBrobizz - priceWeekendNoBrobizz * .2;
                        
            return priceWeekendNoBrobizz;
        }

    }
}
