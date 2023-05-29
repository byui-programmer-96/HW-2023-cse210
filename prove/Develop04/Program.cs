using System;

namespace MenuSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the menu and get user input
            int choice = DisplayMenu();

            // Perform the selected activity
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected activity 1");
                    break;
                case 2:
                    Console.WriteLine("You selected activity 2");
                    break;
                case 3:
                    Console.WriteLine("You selected activity 3");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.ReadLine();
        }

        static int DisplayMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Listing Activity");
            Console.WriteLine("2. Breathing Actvity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Exit");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }

            return choice;
        }
    }
}