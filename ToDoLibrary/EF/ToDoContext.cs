using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoLibrary.Entities;
using ToDoLibrary.Entities.Configuration;
using Task = ToDoLibrary.Entities.Task;

namespace ToDoLibrary.EF
{
    public class ToDoContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
        public ToDoContext() { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    new TaskConfiguration().Configure(modelBuilder.Entity<Task>());
            modelBuilder.ApplyConfiguration(new TaskConfiguration());

            //}
            //public DbSet<Category> Categories { get; set; }
        }
    }
}