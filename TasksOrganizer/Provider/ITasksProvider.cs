using System;
using System.Threading.Tasks;
using TasksOrganizer;

namespace Provider
{
    public interface ITasksProvider
    {
        Task<TasksIterator> GetTasksAsync(DateTime from, DateTime to);
        Task WriteAsync(TaskInfo task);
        Task UpdateAsync(TaskInfo task);
    }
}