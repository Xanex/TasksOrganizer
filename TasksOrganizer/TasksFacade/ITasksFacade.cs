using System.Threading.Tasks;
using TasksOrganizer;

namespace TasksFacade
{
    public interface ITasksFacade
    {
        Task<TasksIterator> GetTodayTaskAsync();
        Task<TasksIterator> GetAllTasks();
        Task UpdateTaskAsync(TaskInfo task);
        Task WriteTaskAsync(TaskInfo task);
    }
}