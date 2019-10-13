using System.Data.Entity;
using ToDoLearning.Domain.Entities;
using ToDoLearning.InfraEstructure.Mapping;

namespace ToDoLearning.InfraEstructure.DataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            : base("StrConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new TaskMap());
        }
    }
}
