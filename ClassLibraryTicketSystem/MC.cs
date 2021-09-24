using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// The MC class inherites from VehicleBaseClass 
    /// </summary>
    public class MC : VehicleBaseClass
    {  
        /// <summary>
        /// Constructor to initialize all the properties
        /// </summary>
        /// <param name="licenseplate">Initializes Licenseplate property</param>
        /// <param name="date">Initializes Date property</param>
        public MC(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public MC()
        {
        }

        /// <summary>
        /// Price() method returns a fixed price 125
        /// </summary>
        /// <returns>Double</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// VehicleType() method returns "MC"
        /// </summary>
        /// <returns>String</returns>
        public override string VehicleType()
        {
            return "MC";
        }

    }
}
