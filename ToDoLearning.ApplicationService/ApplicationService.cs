using ToDoLearning.InfraEstructure.Transaction;
using ToDoLearning.SharedKarnel;
using ToDoLearning.SharedKarnel.Events;

namespace ToDoLearning.ApplicationService
{
    public class ApplicationService
    {
        private IUow _uow;
        private IHandler<DomainNotification> _notifications;

        public ApplicationService(IUow uow)
        {
            _uow = uow;
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
        }

        public bool Commit()
        {
            if (_notifications.HasNotifications())
                return false;

            _uow.Commit();
            return true;
        }
    }
}
