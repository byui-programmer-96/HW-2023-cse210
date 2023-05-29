using System;
using System.Collections.Generic;

namespace VideoCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold the videos
            List<Video> videos = new List<Video>();

            // Create 3-4 videos and add them to the list
            for (int i = 0; i < 3; i++)
            {
                // Create a new video object
                Video video = new Video();

                // Set the appropriate values
                video.Title = $"Video {i + 1}";
                video.Description = $"This is video {i + 1}";
                video.Duration = 60 * (i + 1);

                // Create a list of comments for the video
                List<Comment> comments = new List<Comment>();

                // Add 3-4 comments to the list
                for (int j = 0; j < 3; j++)
                {
                    // Create a new comment object
                    Comment comment = new Comment();

                    // Set the commenter's name and text
                    comment.Name = $"Commenter {j + 1}";
                    comment.Text = $"This is comment {j + 1} for video {i + 1}";

                    // Add the comment to the list
                    comments.Add(comment);
                }

                // Add the list of comments to the video
                video.Comments = comments;

                // Add the video to the list
                videos.Add(video);
            }

            // Print the list of videos
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Description: {video.Description}");
                Console.WriteLine($"Duration: {video.Duration}");
                Console.WriteLine("Comments:");

                // Print the list of comments for the video
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"Name: {comment.Name}");
                    Console.WriteLine($"Text: {comment.Text}");
                }

                Console.WriteLine();
            }
        }
    }

    class Video
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public List<Comment> Comments { get; set; }
    }

    class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }
    }
}