using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalc
{
    class MethodLibrary
    {
        public double ReadValue(
            string prompt,
            double low,
            double high
            )
        {
            double result = 0;
            do
            {
                Console.WriteLine(prompt + "between " + low + "and " + high);
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
            } while ((result < low) || (result > high));
            return result;
        }
    }
}
