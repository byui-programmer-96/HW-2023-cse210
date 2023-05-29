using System;

class Program
    {
        static void Main(string[] args)
        {
            // Sample goals list
            List<Goal> goals = new List<Goal>
            {
                new Goal("Learn a new language", true),
                new Goal("Read 20 books", false),
                new Goal("Exercise 3 times a week", true, true, 3),
                new Goal("Travel to 3 new countries", false, true, 1)
            };

            // Display the goals list
            DisplayGoals(goals);
        }

        static void DisplayGoals(List<Goal> goals)
        {
            // Loop through each goal and display its status
            foreach (Goal goal in goals)
            {
                string status = goal.IsCompleted ? "[X]" : "[ ]";
                string goalText = goal.IsChecklist ? $"{goal.Text} (Completed {goal.TimesCompleted}/{goal.TotalTimes})" : goal.Text;
                Console.WriteLine($"{status} {goalText}");
            }
        }
    }

    class Goal
    {
        public string Text { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsChecklist { get; set; }
        public int TimesCompleted { get; set; }
        public int TotalTimes { get; set; }

        public Goal(string text, bool isCompleted = false, bool isChecklist = false, int totalTimes = 0)
        {
            Text = text;
            IsCompleted = isCompleted;
            IsChecklist = isChecklist;
            TimesCompleted = 0;
            TotalTimes = totalTimes;
        }
    }
