using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reponsitory.GenericRepository
{
    public class GenericRepository<T> : IGeneriRepository<T> where T : class
    {
        ReponsitoryContext RepositoryContext { get; set; }
        public GenericRepository(ReponsitoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public List<T> FindAll()
        {
            return RepositoryContext.Set<T>().ToList();
        }

        public T Get(string code)
        {
            return RepositoryContext.Set<T>().Find(code);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
