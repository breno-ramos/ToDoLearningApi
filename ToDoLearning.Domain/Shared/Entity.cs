using System;

namespace ToDoLearning.Domain.Shared
{
    public abstract class Entity
    {
        protected Guid Id { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
