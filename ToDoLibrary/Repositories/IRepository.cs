using Task = ToDoLibrary.Entities.Task;

namespace ToDoLibrary.Repositories
{
    public interface ITaskRepository
    {
        public List<Task> GetAllTasks();
        public Task CreateTask(Task task);
        public Task getTaskById(int task);

    }
}
