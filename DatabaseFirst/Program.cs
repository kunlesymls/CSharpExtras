using DatabaseFirst.Models;
using System;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MyDbContext();
            var post = new Post()
            {
                Title = "First Post",
                Body = "Lot of text as the body of the post",
                IsPosted = true,
                PostDateTime = DateTime.Now
            };
            db.Posts.Add(post);
            db.SaveChanges();
        }
    }
}

