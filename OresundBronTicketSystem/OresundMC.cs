using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketSystem
{
    // <summary>
    /// The OresundMC class inherites from VehicleBaseClass 
    /// </summary>
    public class OresundMC : VehicleBaseClass
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public OresundMC()
        {
        }

        /// <summary>
        /// Constructor to initialize all the properties
        /// </summary>
        /// <param name="licenseplate">Initializes Licenseplate property</param>
        /// <param name="date">Initializes Date property</param>
        public OresundMC(string licenseplate, DateTime date) : base(licenseplate, date)
        {
        }

        /// <summary>
        /// Price() method returns a regular price 210. Discount applies for Brobizz
        /// </summary>
        /// <returns>Double</returns>
        public override double Price(Brobizz brobizz)
        {
            if (brobizz.MyBrobizz == true)
            {
                return 73;
            }

            return 210;
        }

        /// <summary>
        /// VehicleType() method returns "Oresund MC"
        /// </summary>
        /// <returns>String</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }

    }
}
