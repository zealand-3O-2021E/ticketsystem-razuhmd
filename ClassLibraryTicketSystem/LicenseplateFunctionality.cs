using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// This class checks the length of the numberplate. If it is longer than 7 character, it throws ArgumentException
    /// </summary>
    public class LicenseplateFunctionality
    {
        public LicenseplateFunctionality()
        {
        }

        /// <summary>
        /// Checks licenseplate length and creates Car
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public Car CheckAndCreateCar(string licenseplate, DateTime date)
        {
            if(licenseplate.Length < 8)
            {
                Car car = new Car(licenseplate, date);
                return car;
            }
            else
                throw new ArgumentException("Licenseplate is longer than 7 character !!!");
        }

        /// <summary>
        /// Checks licenseplate length and creates MC
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public MC CheckAndCreateMC(string licenseplate, DateTime date)
        {
            if (licenseplate.Length < 8)
            {
                MC mc = new MC(licenseplate, date);
                return mc;
            }
            else
                throw new ArgumentException("Licenseplate is longer than 7 character !!!");
        }
    }
}
