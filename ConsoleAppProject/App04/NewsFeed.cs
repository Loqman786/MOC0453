using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    /// Mohammed Loqman
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Pathker";
        public List<Post> Posts { get; }

        public int itemNumber;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            Posts = new List<Post>();

            MessagePost post = new MessagePost(AUTHOR, "Wag 1");
            AddPost(post);

            PhotoPost photopost = new PhotoPost(AUTHOR, "Photo.png", "Photo");
            AddPost(photopost);
        }


       
        public void AddPost(Post post)
        {
            Posts.Add(post);
        }

     
        public void Display()
        {
            // display all the posts
            foreach (var (item, index) in Posts.Select((value, i) => (value, i)))
            {
                itemNumber = index + 1;
                Console.WriteLine($" Post number {itemNumber}");
                item.Display();
                Console.WriteLine();  
            }
        }
    }
}