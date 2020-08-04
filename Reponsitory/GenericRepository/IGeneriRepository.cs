using System;
using System.Collections.Generic;
using System.Text;

namespace Reponsitory.GenericRepository
{
   public interface IGeneriRepository<T> where T : class
    {
        List<T> FindAll();
        T Get(string code);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
