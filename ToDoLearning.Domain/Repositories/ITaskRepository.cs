using System;
using System.Collections.Generic;
using ToDoLearning.Domain.Entities;

namespace ToDoLearning.Domain.Repositories
{
    public interface ITaskRepository
    {
        void Create(Task task);
        void Update(Task task);
        void Delete(Guid id);
        IList<Task> GetByUser(Guid userId);
        Task GetById(Guid id);
    }
}
