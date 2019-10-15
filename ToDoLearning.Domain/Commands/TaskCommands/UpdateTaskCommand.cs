using System;

namespace ToDoLearning.Domain.Commands.TaskCommands
{
    public class UpdateTaskCommand
    {
        public UpdateTaskCommand(Guid id, string title)
        {
            Id = id;
            Title = title;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }       
    }
}
