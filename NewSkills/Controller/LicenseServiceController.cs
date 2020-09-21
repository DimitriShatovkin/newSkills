using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSkills.Controller
{
    public class LicenseServiceController
    {
        public int getLincenceRequest(string licenceNumber)
        {
            int numberOne = int.Parse(licenceNumber.Substring(4, 1));
            int numberTwo = int.Parse(licenceNumber.Substring(8, 1));
            int numberThree = int.Parse(licenceNumber.Substring(10, 1));
            int numberFour = int.Parse(licenceNumber.Substring(12, 1));

            return numberOne + numberTwo - numberThree + numberFour;
        }
    }
}
