using System;

namespace ToDoLearning.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
    }   
}
