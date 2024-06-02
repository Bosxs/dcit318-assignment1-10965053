using System;

namespace ConsoleApplications
{
    class GradeCalculator
    {
        public static void Run()
        {
            bool check = false;

            while (!check)
            {
                try
                {
                    Console.WriteLine("Grade Calculator");
                    Console.WriteLine("Enter a numerical grade between 0 and 100:");
                    int grade = int.Parse(Console.ReadLine());

                    if (grade >= 0 && grade <= 100)
                    {
                        check = true;

                        if (grade >= 90)
                        {
                            Console.WriteLine("Grade: A");
                        }
                        else if (grade >= 80)
                        {
                            Console.WriteLine("Grade: B");
                        }
                        else if (grade >= 70)
                        {
                            Console.WriteLine("Grade: C");
                        }
                        else if (grade >= 60)
                        {
                            Console.WriteLine("Grade: D");
                        }
                        else
                        {
                            Console.WriteLine("Grade: F");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please try again. The number should be between 0 and 100.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid numerical grade.");
                }
            }
        }
    }
}
