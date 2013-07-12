using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NormDistributionLib
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DifferenceIntegrate.GetSpecificAreaSize(10000000, 0, 1, 0, 3.77));
            Console.WriteLine(DifferenceIntegrate.GetSpecificAreaPercentage(1000000, 0, 1, 0, 3.77));
            Console.ReadLine();
        }
    }
}
