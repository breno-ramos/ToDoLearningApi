using System;

namespace ToDoLearning.SharedKarnel.Events.Contracts
{
    public interface IDomainEvent
    {
        DateTime DateOccurred { get; }
    }
}
