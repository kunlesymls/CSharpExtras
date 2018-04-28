using DatabaseFirst.Models;
using System.Data.Entity;

namespace DatabaseFirst
{
    public class MyDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Todo> Todo { get; set; }
    }
}
