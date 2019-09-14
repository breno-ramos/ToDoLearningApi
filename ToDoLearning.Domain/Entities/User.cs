using System;
using ToDoLearning.Domain.Scopes;

namespace ToDoLearning.Domain.Entities
{
    public class User
    {
        public User(Guid id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;

            UserScope.ValidUserName(Nome);
            UserScope.ValidEmail(Email);
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
    }   
}
