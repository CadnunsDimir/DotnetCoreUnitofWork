using System.Collections.Generic;
using System.Linq;
using DotnetCoreUnitofWork.Data.Interfaces;
using DotnetCoreUnitofWork.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreUnitofWork.Data.Repositories
{
    public class TaskRepository : Repository<Task>, ITaskRepository
    {
        public TaskRepository(SiteDbContext dbContext) : base(dbContext)
        {
        }
    }
}