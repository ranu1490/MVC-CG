using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCodeFirstInDotNetCoreMVC.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {
        }
        public DbSet<Todoitem> Todoitem { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todoitem>().HasData(
                new Todoitem() { Id = 1, Name = "Meeting With Management", IsComplete = true, Description = "In Meeting need to discuss some points." },
                new Todoitem() { Id = 2, Name = "Go for shopping", IsComplete = false, Description = "List of this this item buy." },
                new Todoitem() { Id = 3, Name = "Call to some one for do some task", IsComplete = false, Description = "Here is task" });
        }
    }
}
