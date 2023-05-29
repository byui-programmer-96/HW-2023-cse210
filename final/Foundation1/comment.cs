using System;

namespace CommentNamespace
{
    public class Comment
    {
        private string name;
        private string text;

        /// <summary>
        /// Constructor for Comment class
        /// </summary>
        /// <param name="name">The name of the person who made the comment</param>
        /// <param name="text">The text of the comment</param>
        public Comment(string name, string text)
        {
            this.name = name;
            this.text = text;
        }

        /// <summary>
        /// Gets the name of the person who made the comment
        /// </summary>
        /// <returns>The name of the person who made the comment</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Gets the text of the comment
        /// </summary>
        /// <returns>The text of the comment</returns>
        public string GetText()
        {
            return text;
        }
    }
}