using System;
using ToDoLearning.Domain.Commands.UserCommands;
using ToDoLearning.Domain.Entities;

namespace ToDoLearning.Domain.Services
{
    public interface IUserApplicationService
    {
        User Create(CreateUserCommand command);

        User Update(UpdateUserCommand command);

        User GetById(Guid id);
    }
}
