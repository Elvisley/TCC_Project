using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8.infra.Repository.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity:  class
    {
        void Add(TEntity obj);
        void Delete(TEntity obj);
        void Delete(int id);
        TEntity Get(int id);
        IEnumerable<TEntity> Get();
        void Update(TEntity obj);
    }
}
