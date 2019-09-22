using System;
using ToDoLearning.Domain.Entities;

namespace ToDoLearning.Domain.Repositories
{
    public interface IUserRepository
    {
        void Create(User task);
        void Update(User task);
        void Delete(Guid id);
        User GetById(Guid id);
    }
}
