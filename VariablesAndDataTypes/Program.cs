using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight?");
            float packageWeight = Convert.ToSingle(Console.ReadLine());
            if (packageWeight > 50.0 )
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");            
            }
            Console.WriteLine("Please enter the package width in cm?");
            float packageWidth = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter the package height in cm?");
            float packageHeight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter the package length in cm?");
            float packageLength = Convert.ToSingle(Console.ReadLine());
            float totDimention = packageWidth + packageHeight + packageLength;
            if (totDimention > 50.0)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                double quote = packageWidth * packageHeight * packageLength/100.0;
                Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C"));
                Console.Read();
            }











            Console.Read();
        }

    }
}
