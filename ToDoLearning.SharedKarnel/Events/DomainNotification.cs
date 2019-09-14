using System;
using ToDoLearning.SharedKarnel.Events.Contracts;

namespace ToDoLearning.SharedKarnel.Events
{
    public class DomainNotification : IDomainEvent
    {
        public DomainNotification(string key, string value)
        {
            Key = key;
            Value = value;
            DateOccurred = DateTime.Now;
        }

        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime DateOccurred { get; private set; }
    }
}
