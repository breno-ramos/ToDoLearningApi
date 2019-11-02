using System;
using ToDoLearning.Domain.Commands.UserCommands;
using ToDoLearning.Domain.Entities;
using ToDoLearning.Domain.Repositories;
using ToDoLearning.Domain.Services;
using ToDoLearning.InfraEstructure.Transaction;

namespace ToDoLearning.ApplicationService
{
    public class UserApplicationService : ApplicationService, IUserApplicationService
    {
        private IUserRepository _repository;

        public UserApplicationService(IUow uow, IUserRepository repository)
            : base(uow)
        {
            _repository = repository;
        }

        public User Create(CreateUserCommand command)
        {
            var user = new User(command.Nome, command.Email);
            _repository.Create(user);

            if(Commit())                
                return user;

            return null;
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

            if(Commit())
                return user;

            return null;
        }
    }
}
