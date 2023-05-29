using System;

namespace PointTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the PointTracker function with user input
            Console.WriteLine(PointTracker());
        }

        static int PointTracker()
        {
            /*
            This function takes user input for points earned and returns the total points earned.
            The function continues to prompt the user for input until a negative number is entered.

            Returns:
            int: The total points earned
            */

            int totalPoints = 0;
            int pointsEarned = 0;

            Console.WriteLine("Enter points earned (negative number to exit):");

            while (pointsEarned >= 0)
            {
                try
                {
                    pointsEarned = Convert.ToInt32(Console.ReadLine());
                    if (pointsEarned >= 0)
                    {
                        totalPoints += pointsEarned;
                        Console.WriteLine("Enter points earned (negative number to exit):");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            return totalPoints;
        }
    }
}