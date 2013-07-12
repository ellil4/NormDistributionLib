using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NormDistributionLib
{
    public static class ValueY
    {
        //static double PIE = 3.141592653589793238462643383279;
        static double E = 2.718281828459;
        static double Sqrt2PIE = 2.506628274631000502415765284811;

        public static double GetValue(double Mean, double SD, double X)
        {
            double retval = 0;

            retval = (1 / (SD * Sqrt2PIE)) * 
                Math.Pow(E, -(Math.Pow((X - Mean), 2.0) / (2 * Math.Pow(SD, 2.0))));

            return retval;
        }
    }
}
