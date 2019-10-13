using ToDoLearning.InfraEstructure.DataContext;

namespace ToDoLearning.InfraEstructure.Transaction
{
    public class Uow : IUow
    {
        private readonly AppDataContext _context;

        public Uow(AppDataContext context) => _context = context;

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback() { }
    }
}
