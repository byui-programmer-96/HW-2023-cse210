using System;
using System.Threading;

namespace BreathingPrompts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the duration of each breathing exercise
            int duration = 30;

            // Start the breathing exercises
            StartBreathingPrompts(duration);
        }

        /// <summary>
        /// Starts a series of breathing exercises with prompts and a timer.
        /// </summary>
        /// <param name="duration">The duration of each breathing exercise in seconds.</param>
        static void StartBreathingPrompts(int duration)
        {
            try
            {
                // Check if the duration is valid
                if (duration <= 0)
                {
                    throw new ArgumentException("Duration must be a positive integer");
                }

                // Loop through the breathing exercises
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Breathing exercise {i}: Inhale deeply and hold for {duration} seconds");
                    Thread.Sleep(duration * 1000);
                    Console.WriteLine($"Exhale slowly and completely");
                    Thread.Sleep(2000);
                }
            }
            catch (ArgumentException e)
            {
                // Log the error
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}