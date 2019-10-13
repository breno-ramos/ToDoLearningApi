using System;
using System.Data.Entity;
using System.Linq;
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
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid id)
        {
            return _context.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(User user)
        {
            _context
                .Entry<User>(user)
                .State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
