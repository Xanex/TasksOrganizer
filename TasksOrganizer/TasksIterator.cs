using System.Collections;
using System.Collections.Generic;

namespace TasksOrganizer
{
    public class TasksIterator : IEnumerable<TaskInfo>
    {
        private readonly List<TaskInfo> _tasks = new List<TaskInfo>();

        internal void AddTask(TaskInfo task)
        {
            _tasks.Add(task);
        }

        public IEnumerator<TaskInfo> GetEnumerator()
        {
            foreach (var taskInfo in _tasks)
            {
                yield return taskInfo;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}