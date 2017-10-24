using DotnetCoreUnitofWork.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreUnitofWork.Data
{
    public class SiteDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }        
    }
}