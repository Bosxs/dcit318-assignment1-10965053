using System;

namespace ConsoleApplications
{
    class TicketPriceCalculator
    {
        public static void Run()
        {
            bool check = false;

            while (!check)
            {
                try
                {
                    Console.WriteLine("Ticket Price Calculator");
                    Console.WriteLine("Enter your age:");
                    int age = int.Parse(Console.ReadLine());

                    if (age >= 0)
                    {
                        check = true;

                        if (age <= 12 || age >= 65)
                        {
                            Console.WriteLine("Ticket price: GHC7");
                        }
                        else
                        {
                            Console.WriteLine("Ticket price: GHC10");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid age.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }
            }
        }
    }
}
