using System;

namespace ToDoLearning.Domain.Commands.TaskCommands
{
    public class DeleteTaskCommand
    {
        public DeleteTaskCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
