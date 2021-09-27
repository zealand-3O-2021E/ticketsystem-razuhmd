using ClassLibraryTicketSystem;
using System;

namespace OresundBronTicketSystem
{
    /// <summary>
    /// The OresundCar class inherites from VehicleBaseClass 
    /// </summary>
    public class OresundCar : VehicleBaseClass
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public OresundCar() : base()
        {
        }

        /// <summary>
        /// Constructor to initialize all the properties
        /// </summary>
        /// <param name="licenseplate">Initializes Licenseplate property</param>
        /// <param name="date">Initializes Date property</param>
        public OresundCar(string licenseplate, DateTime date) : base(licenseplate, date)
        {
        }

        /// <summary>
        /// Price() method returns a regular price 410. Discount applies for Brobizz
        /// </summary>
        /// <returns>Double</returns>
        public override double Price(Brobizz brobizz)
        {
            if (brobizz.MyBrobizz == true)
            {
                return 161;
            }

            return 410;
        }

        /// <summary>
        /// VehicleType() method returns "Oresund car"
        /// </summary>
        /// <returns>String</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }

    }
}
