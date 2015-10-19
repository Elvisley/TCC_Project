using ConsoleApplication8.infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ConsoleApplication8.infra.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
      
        protected MyDataContext _context { get; private set; }

        public RepositoryBase()
        {
            _context = new MyDataContext();
        }

        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = Get(id);
            Delete(obj);
        }

        public void Delete(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> Get()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
