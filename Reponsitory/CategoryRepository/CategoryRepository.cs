using Model.Model;
using Model;
using Reponsitory.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reponsitory
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ReponsitoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
