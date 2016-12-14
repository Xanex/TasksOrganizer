using System;

namespace TasksOrganizer
{
    public class TaskInfo
    {
        public string Id { get; internal set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public TaskStatus Status { get; set; }
    }
}