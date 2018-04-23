using System;

namespace DatabaseFirst.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PostDateTime { get; set; }
        public bool IsPosted { get; set; }
    }
}
