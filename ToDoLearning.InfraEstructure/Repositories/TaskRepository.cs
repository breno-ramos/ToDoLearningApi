using System;
using System.Collections.Generic;
using ToDoLearning.Domain.Entities;
using ToDoLearning.Domain.Repositories;

namespace ToDoLearning.InfraEstructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void Create(Task task)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Task> GetByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void Update(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
