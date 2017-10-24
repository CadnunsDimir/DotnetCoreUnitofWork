using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DotnetCoreUnitofWork.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreUnitofWork.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public DbSet<TEntity> DbSet {get{return Context.Set<TEntity>();}}
        public DbContext Context;
        public Repository(DbContext dbContext) => Context = dbContext;

        public TEntity Get(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }
    }
}