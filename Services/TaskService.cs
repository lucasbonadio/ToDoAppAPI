using ToDoApp.Api.Models;

namespace ToDoApp.Api.Services
{
    public class TaskService
    {
        private readonly List<TaskItem> _tasks = [];
        private int _nextId = 1;

        public IEnumerable<TaskItem> GetAll() => _tasks;

        public TaskItem Add(TaskItemDto dto)
        {
            var task = new TaskItem
            {
                Id = _nextId++,
                Title = dto.Title,
                Description = dto.Description,
                IsCompleted = dto.IsCompleted
            };
            _tasks.Add(task);
            return task;
        }

        public TaskItem? GetById(int id) => _tasks.FirstOrDefault(t => t.Id == id);

        public bool Update(int id, TaskItemDto dto)
        {
            var task = GetById(id);
            if (task == null) return false;
            task.Title = dto.Title;
            task.Description = dto.Description;
            task.IsCompleted = dto.IsCompleted;
            return true;
        }

        public bool Delete(int id)
        {
            var task = GetById(id);
            if (task == null) return false;
            _tasks.Remove(task);
            return true;
        }
    }
}