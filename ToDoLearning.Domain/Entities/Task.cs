using System;
using ToDoLearning.Domain.Shared;

namespace ToDoLearning.Domain.Entities
{
    public class Task : Entity
    {
        public Task(string title)
        {
            Title = title;
            CreateDate = DateTime.Now;
        }

        public string Title { get; private set; }
        public DateTime CreateDate { get; private set; }       
    }
}
