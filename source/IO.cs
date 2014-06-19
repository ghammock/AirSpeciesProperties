using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirSpeciesProperties
{
    class IO
    {
        /// <summary>
        /// Check a given string to determine if it can be parsed as a decimal value.
        /// </summary>
        /// <param name="str">The string that is to be checked.</param>
        /// <returns>True, if the string can be parsed as a decimal.  False otherwise.</returns>
        static public bool validNumber(string str)
        {
            double temp;
            if (Double.TryParse(str, out temp))
                return true;
            else
                return false;
        }
    }
}
