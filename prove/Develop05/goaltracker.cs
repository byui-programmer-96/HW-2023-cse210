using System;

namespace GoalTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the function to track a goal
            TrackGoal("Learn C#");

            // Call the function to mark the goal as complete
            MarkGoalComplete("Learn C#");
        }

        /// <summary>
        /// This function tracks a goal and logs it to the console.
        /// </summary>
        /// <param name="goal">The goal to be tracked</param>
        static void TrackGoal(string goal)
        {
            try
            {
                // Log the goal to the console
                Console.WriteLine($"Tracking goal: {goal}");
            }
            catch (Exception e)
            {
                // Log the error
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        /// <summary>
        /// This function marks a goal as complete and logs it to the console.
        /// </summary>
        /// <param name="goal">The goal to be marked as complete</param>
        static void MarkGoalComplete(string goal)
        {
            try
            {
                // Log the goal as complete to the console
                Console.WriteLine($"Goal '{goal}' marked as complete!");
            }
            catch (Exception e)
            {
                // Log the error
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}