using Unity;
using Unity.Lifetime;
using ToDoLearning.Domain.Repositories;
using ToDoLearning.InfraEstructure.Repositories;
using ToDoLearning.Domain.Services;
using ToDoLearning.ApplicationService;
using ToDoLearning.InfraEstructure.DataContext;
using ToDoLearning.SharedKarnel.Events;
using ToDoLearning.SharedKarnel;

namespace ToDoLearning.CrossCutting
{
    public static class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<ITaskRepository, TaskRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITaskApplicationService, TaskApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserApplicationService, UserApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
        }
    }
}
