using System;

class PackageExpress
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        Console.Write("Please enter the package weight: ");
        double weight = double.Parse(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        Console.Write("Please enter the package width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        double length = double.Parse(Console.ReadLine());

        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
            return;
        }

        double quote = (height * width * length * weight) / 100.0;
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
        Console.WriteLine("Thank you!");
    }
}
