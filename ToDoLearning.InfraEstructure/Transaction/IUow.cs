using System;

namespace ToDoLearning.InfraEstructure.Transaction
{
    public interface IUow
    {
        void Commit();
        void Rollback();
    }
}
