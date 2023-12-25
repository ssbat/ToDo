using Microsoft.AspNetCore.Mvc;
using ToDoLibrary.Repositories;

using Task = ToDoLibrary.Entities.Task;


namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            return Ok(_taskRepository.GetAllTasks());
        }

        [HttpGet("{id}")]
        public IActionResult GeTaskById(int id)
        {
            return Ok(_taskRepository.getTaskById(id));
        }
    }
}
