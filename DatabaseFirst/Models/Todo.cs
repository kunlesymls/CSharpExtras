using System;

namespace DatabaseFirst.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsComplted { get; set; }
    }
}
