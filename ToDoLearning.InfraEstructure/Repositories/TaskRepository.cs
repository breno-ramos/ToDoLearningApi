using System;
using System.Collections.Generic;
using System.Data.Entity;
using ToDoLearning.Domain.Entities;
using ToDoLearning.Domain.Repositories;
using ToDoLearning.InfraEstructure.DataContext;

namespace ToDoLearning.InfraEstructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private AppDataContext _context;

        public TaskRepository()
        {
            _context = new AppDataContext();
        }

        public void Create(Task task)
        {
            _context.Entry(task.User).State = EntityState.Unchanged;
            _context.Tasks.Add(task);
            _context.SaveChanges();
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
