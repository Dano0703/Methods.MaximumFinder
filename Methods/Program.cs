using System;

namespace Methods
{
    class MaximumFinder
    {
        // obtain three flaoting-point values and determine maximu value
        static void Main()
        {
            // prompt for and input three flaoting-onit values
            Console.Write("Enter first floating point value: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second floating point value: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.Write("Enter third floating point value: ");
            double number3 = double.Parse(Console.ReadLine());

            // Determine the maximum of three values
            double result = Maximum(number1, number2, number3);

            //Displays maximum result
            Console.WriteLine("Maximum is: " + result);
        }

        static double Maximum(double x, double y, double z)
        {
            double maximumValue = x; // assume x is the largest to start
            
            //determine whether Y is greater than maximum value
            if (y > maximumValue)
            {
                maximumValue = y;
            }
            if (z > maximumValue)
            {
                maximumValue = z;
            }
            return maximumValue;
        }
    }
}
