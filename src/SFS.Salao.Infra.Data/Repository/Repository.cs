using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SFS.Salao.Domain.Interfaces.Repository;
using SFS.Salao.Infra.Data.Contexts;

namespace SFS.Salao.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected SalaoContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new SalaoContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Adicionar(TEntity obj)
        {
            obj = DbSet.Add(obj);
            SaveChanges();

            return obj;
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        // public IEnumerable<TEntity> ObterTodos(int take, int skip)
        public virtual IEnumerable<TEntity> ObterTodos()
        {
            //return DbSet.Take(take).Skip(skip).ToList();
            return DbSet.ToList();
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();

            return obj;
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(ObterPorId(id));
            SaveChanges();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}