using Microsoft.AspNetCore.Mvc;
using ToDoApp.Api.Models;
using ToDoApp.Api.Services;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private static readonly TaskService _service = new();

    /// <summary>
    /// List all tasks.
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<TaskItem>> GetTasks()
    {
        return Ok(_service.GetAll());
    }

    /// <summary>
    /// Creates a new task.
    /// </summary>
    [HttpPost]
    public ActionResult<TaskItem> CreateTask(TaskItemDto dto)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState);

        var task = _service.Add(dto);
        return CreatedAtAction(nameof(GetTasks), new { id = task.Id }, task); 
    }

    /// <summary>
    /// Update an existing task.
    /// </summary>
    [HttpPut("{id}")]
    public IActionResult UpdateTask(int id, [FromBody] TaskItemDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var updated = _service.Update(id, dto);
        if (!updated)
            return NotFound(new { message = "Task not found." });

        return NoContent();
    }

    /// <summary>
    /// Deletes a task.
    /// </summary>
    [HttpDelete("{id}")]
    public IActionResult DeleteTask(int id)
    {
        var deleted = _service.Delete(id);
        if (!deleted)
            return NotFound(new { message = "Task not found." });

        return NoContent();
    }
}