using System;
using System.Collections.Generic;
using ToDoLearning.SharedKarnel.Events.Contracts;

namespace ToDoLearning.SharedKarnel
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
