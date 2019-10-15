using System;
using System.Collections.Generic;
using ToDoLearning.Domain.Commands.TaskCommands;
using ToDoLearning.Domain.Entities;

namespace ToDoLearning.Domain.Services
{
    public interface ITaskApplicationService
    {
        Task Create(CreateTaskCommand command);
        Task Update(UpdateTaskCommand command);
        Task Delete(DeleteTaskCommand command);
        IList<Task> GetByUser(Guid userId);
        Task GetById(Guid id);
    }
}
