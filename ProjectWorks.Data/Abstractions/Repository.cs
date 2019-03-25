using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ProjectWorks.Data.Resources;



namespace ProjectWorks.Data.Abstractions
{
    public abstract class Repository<TContext, TEntity, TKey>
         where TContext : DbContext, new()
         where TEntity : class
         where TKey : IEquatable<TKey>
    {



        protected TContext context;
        protected DbSet<TEntity> set;



        public IQueryable<TEntity> Entities {
            get {
                return this.GetQueryable();
            }
        }



        public Repository(TContext context)
        {
            this.context = context;
            this.set = this.context.Set<TEntity>();
        }



        protected virtual Expression<Func<TEntity, Boolean>> GetKeyComparer(TKey id)
        {
            // Get key property name
            var name = this.context.Model
                .FindEntityType(typeof(TEntity))
                .FindPrimaryKey()
                .Properties
                .Select(m => m.Name)
                .Single();

            // Create key property selector expression (m.EntityID)
            var parameter = Expression.Parameter(typeof(TEntity), "m");
            var property = ExpressionUtils.GetProperty(parameter, name);

            // Create comparer expression (m.EntityID == id)
            var value = Expression.Constant(id);
            var equals = Expression.Equal(property, value);

            // Return key comparer expression (m => m.EntityID == id)
            return Expression.Lambda<Func<TEntity, Boolean>>(equals, parameter);
        }



        protected virtual IQueryable<TEntity> GetQueryable()
        {
            return this.set;
        }



        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await this.GetAll(null, null, 0, 0);
        }



        public virtual async Task<IEnumerable<TEntity>> GetAll(ResourceParameters parameters)
        {
            var query = this.GetQueryable();

            return await query
                .Apply(parameters)
                .ToListAsync();
        }



        public virtual async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, Boolean>> predicate = null, Expression<Func<TEntity, Object>> sorting = null, Int32 skip = 0, Int32 take = 0)
        {
            var query = this.GetQueryable();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (sorting != null)
            {
                query = query.OrderBy(sorting);
            }

            if (skip >= 0)
            {
                query = query.Skip(Math.Max(skip, 0));
            }

            if (take > 0)
            {
                query = query.Take(Math.Max(take, 0));
            }

            return await query
                .ToListAsync();
        }



        public virtual async Task<TEntity> Get(TKey id)
        {
            return await this.Get(this.GetKeyComparer(id));
        }



        public virtual async Task<TEntity> Get(Expression<Func<TEntity, Boolean>> predicate)
        {
            var query = this.GetQueryable();

            return await query
                .Where(predicate)
                .FirstOrDefaultAsync();
        }



        public virtual async Task<TEntity> Create(TEntity entity)
        {
            this.set.Add(entity);

            await this.context.SaveChangesAsync();

            return entity;
        }



        public virtual async Task<IEnumerable<TEntity>> Create(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                this.context.Entry(entity).State = EntityState.Added;
            }

            await this.context.SaveChangesAsync();

            return entities;
        }



        public virtual async Task<TEntity> Update(TEntity entity)
        {
            if (this.context.Entry(entity).State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            this.set.Update(entity);

            await this.context.SaveChangesAsync();

            return entity;
        }



        public virtual async Task<IEnumerable<TEntity>> Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                if (this.context.Entry(entities).State == EntityState.Detached)
                {
                    this.set.Attach(entity);
                }

                this.context.Entry(entity).State = EntityState.Modified;
            }

            await this.context.SaveChangesAsync();

            return entities;
        }



        public virtual async Task<TEntity> Delete(TKey id)
        {
            var entity = await this.Get(id);

            return await this.Delete(entity);
        }



        public virtual async Task<TEntity> Delete(TEntity entity)
        {
            this.set.Remove(entity);

            await this.context.SaveChangesAsync();

            return entity;
        }



        public virtual async Task<IEnumerable<TEntity>> Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                this.context.Entry(entity).State = EntityState.Deleted;
            }

            await this.context.SaveChangesAsync();

            return entities;
        }



        public virtual async Task<IEnumerable<PropertyEntry>> Changes(TEntity entity)
        {
            return await Task.Run(() =>
            {
                this.context.ChangeTracker.DetectChanges();

                return this.context.Entry(entity).GetChanges();
            });
        }
    }
}
