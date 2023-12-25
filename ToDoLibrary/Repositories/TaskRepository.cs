using Microsoft.EntityFrameworkCore;
using Task = ToDoLibrary.Entities.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoLibrary.Entities.Configuration;
using ToDoLibrary.EF;

namespace ToDoLibrary.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ToDoContext dbContext;
        public TaskRepository(ToDoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Task> GetAllTasks()
        {
            return dbContext.Set<Task>().ToList();
        }
        public Task CreateTask(Task task)
        {
            dbContext.Set<Task>().Add(task);
            dbContext.SaveChanges();
            return task;
        }
        public Task getTaskById(int taskID)
        {
            return dbContext.Set<Task>().Where(task=>task.Id==taskID).FirstOrDefault();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new TaskConfiguration());
        //}
    }
}
