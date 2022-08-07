using Microsoft.EntityFrameworkCore;
using TodoMVC.Interfaces;

namespace TodoMVC.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions opt) : base(opt)
        {
            if (Database.EnsureCreated())
            {
                var data = new List<Todo>
                {
                    new() { Name = "Do Homework", Status = Status.Open },
                    new() { Name = "Play football", Status = Status.InProgress },
                };

                AddRange(data);
                SaveChanges();
            }
        }

        public DbSet<Todo> Todos { get; set; }
    }
}