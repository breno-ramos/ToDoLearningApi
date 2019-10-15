using System;
using ToDoLearning.Domain.Shared;
using ToDoLearning.Domain.Scopes;

namespace ToDoLearning.Domain.Entities
{
    public class Task : Entity
    {
        protected Task() { }
        
        public Task(User user, string title)
        {
            User = user;
            Title = title;
            CreateDate = DateTime.Now;

            TaskScope.ValidTaskTitle(Title);
        }

        public void Update(string title)
        {
            Title = title;
        }
        
        public string Title { get; private set; }
        public DateTime CreateDate { get; private set; }
        public User User { get; private set; }
    }
}
