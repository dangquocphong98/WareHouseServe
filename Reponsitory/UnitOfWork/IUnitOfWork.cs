using Reponsitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reponsitory.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository _IProduct { get; }
        ICategoryRepository _ICategory { get; }
        int Save();
    }
}
