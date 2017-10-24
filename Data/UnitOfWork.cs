using DotnetCoreUnitofWork.Data.Interfaces;
using DotnetCoreUnitofWork.Data.Repositories;

namespace DotnetCoreUnitofWork.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private SiteDbContext _context;

        public UnitOfWork(SiteDbContext context)
        {
            _context = context;
            Tasks = new TaskRepository(_context);
        }

        public ITaskRepository Tasks {get; private set;}

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
     
    }
}