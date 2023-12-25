using Microsoft.AspNetCore.Mvc;
using ToDoLibrary.Repositories;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ITaskRepository taskRepository;


    public WeatherForecastController(ILogger<WeatherForecastController> logger,ITaskRepository repo)
    {
        _logger = logger;
        taskRepository = repo;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        taskRepository.CreateTask(new ToDoLibrary.Entities.Task { Name = "saad", IsCompleted = true }); ;
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();

    }
}
