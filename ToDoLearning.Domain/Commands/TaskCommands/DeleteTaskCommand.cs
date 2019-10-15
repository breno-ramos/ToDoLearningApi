using System;

namespace ToDoLearning.Domain.Commands.TaskCommands
{
    public class DeleteTaskCommand
    {
        public Guid Id { get; set; }
    }
}
