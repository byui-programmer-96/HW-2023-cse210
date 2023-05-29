using System;

namespace ReflectionPrompts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the reflection prompts function
            ReflectionPrompts();
        }

        static void ReflectionPrompts()
        {
            /*
             * This function prompts the user with a series of reflection questions and 
             * prints their responses to the console.
             */

            // Prompt the user with the first reflection question
            Console.WriteLine("What is something you learned today?");

            // Get the user's response
            string response1 = Console.ReadLine();

            // Print the user's response to the console
            Console.WriteLine($"You learned: {response1}");

            // Prompt the user with the second reflection question
            Console.WriteLine("What is something you struggled with today?");

            // Get the user's response
            string response2 = Console.ReadLine();

            // Print the user's response to the console
            Console.WriteLine($"You struggled with: {response2}");

            // Prompt the user with the third reflection question
            Console.WriteLine("What is something you want to improve on tomorrow?");

            // Get the user's response
            string response3 = Console.ReadLine();

            // Print the user's response to the console
            Console.WriteLine($"You want to improve on: {response3}");
        }
    }
}