using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GoalTracker
{
    [Serializable]
    public class Goal
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Goal(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

    public static class GoalTracker
    {
        private static readonly string filePath = "goals.dat";

        public static void SaveGoals(Goal[] goals)
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, goals);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error saving goals: {e.Message}");
            }
        }

        public static Goal[] LoadGoals()
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (Goal[])formatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error loading goals: {e.Message}");
                return new Goal[0];
            }
        }
    }
}