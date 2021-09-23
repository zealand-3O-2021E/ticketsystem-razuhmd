using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// The Car class has two properties: Licenseplate, Date. It has two methods: Price(), VehicleType(). 
    /// </summary>
    public class Car
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Constructor to initialize all the properties
        /// </summary>
        /// <param name="licenseplate">Initializes Licenseplate property</param>
        /// <param name="date">Initializes Date property</param>
        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// Price() method returns a fixed price 240
        /// </summary>
        /// <returns>Double</returns>
        public double Price()
        {
            return 240;
        }

        public string VehicleType()
        {
            return "Car";
        }

    }
}
