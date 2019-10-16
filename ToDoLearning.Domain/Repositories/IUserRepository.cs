using System;
using ToDoLearning.Domain.Entities;

namespace ToDoLearning.Domain.Repositories
{
    public interface IUserRepository
    {
        void Create(User user);
        void Update(User user);
        void Delete(Guid id);
        User GetById(Guid id);
    }
}
