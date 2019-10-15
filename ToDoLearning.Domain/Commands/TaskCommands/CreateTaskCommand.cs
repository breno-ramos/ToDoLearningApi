using System;

namespace ToDoLearning.Domain.Commands.TaskCommands
{
    public class CreateTaskCommand
    {
        public CreateTaskCommand(Guid userId, string title)
        {
            UserId = userId;
            Title = title;
        }

        public Guid UserId { get; set; }
        public string Title { get; set; }
    }
}
