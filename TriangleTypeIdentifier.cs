using System;

namespace ConsoleApplications
{
    class TriangleTypeIdentifier
    {
        public static void Run()
        {
            double side1 = GetSideLength("Enter the length of side 1:");
            double side2 = GetSideLength("Enter the length of side 2:");
            double side3 = GetSideLength("Enter the length of side 3:");

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }

        static double GetSideLength(string prompt)
        {
            bool check = false;
            double sideLength = 0;

            while (!check)
            {
                try
                {
                    Console.WriteLine(prompt);
                    sideLength = double.Parse(Console.ReadLine());

                    if (sideLength > 0)
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid numerical value.");
                }
            }

            return sideLength;
        }
    }
}
