using Model;
using Model.Model;
using Reponsitory.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reponsitory
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ReponsitoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
