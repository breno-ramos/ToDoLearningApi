using System;
using ToDoLearning.Domain.Commands.UserCommands;
using ToDoLearning.Domain.Entities;
using ToDoLearning.Domain.Repositories;
using ToDoLearning.Domain.Services;

namespace ToDoLearning.ApplicationService
{
    public class UserApplicationService : IUserApplicationService
    {
        private IUserRepository _repository;
        public UserApplicationService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User Create(CreateUserCommand command)
        {
            var user = new User(command.Nome, command.Email);
            _repository.Create(user);
            return user;
        }

        public User GetById(Guid id)
        {
            return _repository.GetById(id);
            
        }

        public User Update(UpdateUserCommand command)
        {
            var user = _repository.GetById(command.Id);
            user.Update(command.Nome, command.Email);
            _repository.Update(user);
            return user;

        }
    }
}
