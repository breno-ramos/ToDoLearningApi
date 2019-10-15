using System;
using System.Collections.Generic;
using ToDoLearning.Domain.Commands.TaskCommands;
using ToDoLearning.Domain.Entities;
using ToDoLearning.Domain.Repositories;
using ToDoLearning.Domain.Services;

namespace ToDoLearning.ApplicationService
{
    public class TaskApplicationService : ITaskApplicationService
    {
        private ITaskRepository _repository;
        private IUserRepository _userRepository;
        public TaskApplicationService(ITaskRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public Task Create(CreateTaskCommand command)
        {
            var user = _userRepository.GetById(command.UserId);
            var task = new Task(user, command.Title);
            _repository.Create(task);
            return task;
        }

        public Task Delete(DeleteTaskCommand command)
        {
            var task = _repository.GetById(command.Id);
            _repository.Delete(task.Id);
            return task;
        }

        public Task GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IList<Task> GetByUser(Guid userId)
        {
            return _repository.GetByUser(userId);
        }

        public Task Update(UpdateTaskCommand command)
        {
            var task = _repository.GetById(command.Id);
            task.Update(command.Title);
            _repository.Update(task);
            return task;
        }
    }
}
