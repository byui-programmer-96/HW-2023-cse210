using System;

namespace VideoLibrary
{
    public class Video
    {
        private string title;
        private string author;
        private int length;

        /// <summary>
        /// Constructor for Video class
        /// </summary>
        /// <param name="title">Title of the video</param>
        /// <param name="author">Author of the video</param>
        /// <param name="length">Length of the video in seconds</param>
        public Video(string title, string author, int length)
        {
            this.title = title;
            this.author = author;
            this.length = length;
        }

     
        public string GetTitle()
        {
            return title;
        }

   
        public string GetAuthor()
        {
            return author;
        }

   
        public int GetLength()
        {
            return length;
        }
    }
}