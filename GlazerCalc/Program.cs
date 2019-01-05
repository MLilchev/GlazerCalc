using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalc
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //    double width, height, woodLength, glassArea;
            double glassArea; 

            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;

            //    string widthString, heightString;

            //    do {
            //        Console.Write("Give the width of the window between " + MIN_WIDTH + " and " + MAX_WIDTH + " :");
            //        widthString = Console.ReadLine();
            //        width = double.Parse(widthString);
            //    } while ( width < MIN_WIDTH || width > MAX_WIDTH );

            //    do {
            //        Console.Write("Give the height of the window between " + MIN_HEIGHT + " and " + MAX_HEIGHT + " :");
            //        heightString = Console.ReadLine();
            //        height = double.Parse(heightString);
            //    } while ( height < MIN_HEIGHT || height > MAX_HEIGHT);

            //    woodLength = 2 * (width + height) * 3.25;

            //    glassArea = 2 * (width * height);

            //    Console.WriteLine("The legth of the wood is " + woodLength + " feet ");
            //    Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            //
            MethodLibrary methodLibrary = new MethodLibrary();
            double windowWidth = methodLibrary.ReadValue("Enter width of window: ", MIN_WIDTH, MAX_WIDTH);
            double windowHeight = methodLibrary.ReadValue("Enter height of window: ", MIN_HEIGHT, MAX_HEIGHT);

            glassArea = 2 * (windowWidth * windowHeight);

        }
    }
}
