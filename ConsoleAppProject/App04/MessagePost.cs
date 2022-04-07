using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// </summary>
    /// <author>
    /// Mohammed Loqman
    /// </author>
    public class MessagePost : Post
    {
        public String Message { get; }

        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>
        public MessagePost(String author, String text) : base(author)
        {
            Message = text;
        }

        
        public override void Display()
        {
            Console.WriteLine($"   Message: {Message}");

            base.Display();
        }
    }
}