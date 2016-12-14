using System;
using System.Threading.Tasks;
using Provider;
using TasksOrganizer;

namespace TasksFacade
{
    public class DefaultTasksFacade : ITasksFacade
    {
        private readonly ITasksProvider _provider;
        public DefaultTasksFacade(ITasksProvider provider)
        {
            _provider = provider;
        }

        public Task<TasksIterator> GetTodayTaskAsync()
        {
            var today = DateTime.Today;
            return _provider.GetTasksAsync(today, today.AddHours(23).AddMinutes(59).AddSeconds(59));
        }

        public Task<TasksIterator> GetAllTasks()
        {
            return _provider.GetTasksAsync(DateTime.MinValue, DateTime.MaxValue);
        }

        public Task UpdateTaskAsync(TaskInfo task)
        {
            return _provider.UpdateAsync(task);
        }

        public Task WriteTaskAsync(TaskInfo task)
        {
            return _provider.WriteAsync(task);
        }
    }
}