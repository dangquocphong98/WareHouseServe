using Model;
using Reponsitory;
using System;
using System.Collections.Generic;
using System.Text;


namespace Reponsitory.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ReponsitoryContext _repoContext;
        private IProductRepository _product;
        private ICategoryRepository _category;

        public UnitOfWork(ReponsitoryContext repoContext)
        {
            _repoContext = repoContext;
        }
        public IProductRepository _IProduct
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_repoContext);
                }
                return _product;
            }
        }

        public ICategoryRepository _ICategory {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_repoContext);
                }
                return _category;
            }
        }

        public int Save()
        {
            return _repoContext.SaveChanges();
        }
    }
}
