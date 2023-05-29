using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store video titles and their comments
            Dictionary<string, List<string>> videos = new Dictionary<string, List<string>>();

            // Add some sample videos and comments
            videos.Add("Funny Cats Compilation", new List<string> { "Haha, this is hilarious!", "I love cats so much" });
            videos.Add("Top 10 Movie Trailers", new List<string> { "Can't wait to see these movies!", "Great selection" });

            // Display the videos and their comments
            foreach (KeyValuePair<string, List<string>> video in videos)
            {
                Console.WriteLine($"Video: {video.Key}");
                Console.WriteLine("Comments:");
                foreach (string comment in video.Value)
                {
                    Console.WriteLine(comment);
                }
                Console.WriteLine();
            }
        }
    }
}