namespace ToDoApp.Api.Models
{
    public class TaskItemDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}