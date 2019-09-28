using System;
using ToDoLearning.Domain.Entities;
using ToDoLearning.Domain.Repositories;
using ToDoLearning.InfraEstructure.DataContext;

namespace ToDoLearning.InfraEstructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDataContext _context;

        public UserRepository()
        {
            _context = new AppDataContext();
        }

        public void Create(User user)
        {
            _context.Users.Add(user);
            int result = _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
