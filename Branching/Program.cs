using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            
            Console.WriteLine("Please enter the package width:");
            int packWidth = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter the package height:");
            int packHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packLength = Convert.ToInt32(Console.ReadLine());

            //If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
            int packDims = packWidth + packHeight + packLength;
            decimal estimate = ((packWidth * packHeight * packLength) * packWeight) / 100;
            decimal totalEst = Convert.ToDecimal(string.Format("{0:F2}", estimate));

            if (packDims > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: " + "$" + totalEst);
            }

            //Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
