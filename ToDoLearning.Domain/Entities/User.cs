using System.Collections.Generic;
using System.Linq;
using ToDoLearning.Domain.Shared;
using ToDoLearning.Domain.Scopes;

namespace ToDoLearning.Domain.Entities
{
    public class User : Entity
    {
        private IList<Task> _tasks;

        protected User() { }

        public User(string nome, string email)
        {
            Nome = nome;
            Email = email;
            _tasks = new List<Task>();

            UserScope.ValidUserName(Nome);
            UserScope.ValidEmail(Email);
        }
        public void Update(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        //public ICollection<Task> Tasks { get { return _tasks.ToArray(); } }

        //public void AddTask(Task task)
        //{
        //    _tasks.Add(task);
        //}
    }
}