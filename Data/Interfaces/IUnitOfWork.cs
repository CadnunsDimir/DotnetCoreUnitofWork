using System;

namespace DotnetCoreUnitofWork.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
         ITaskRepository Tasks {get;}
         int Complete();
    }
}