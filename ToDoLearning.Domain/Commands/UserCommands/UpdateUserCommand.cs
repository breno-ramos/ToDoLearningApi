using System;

namespace ToDoLearning.Domain.Commands.UserCommands
{
    public class UpdateUserCommand
    {
        public UpdateUserCommand(Guid id, string nome, string email)
        {
            Nome = nome;
            Email = email;
            Id = id;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public Guid Id { get; set; }
    }
}
