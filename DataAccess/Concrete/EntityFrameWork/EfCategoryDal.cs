using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFrameWork.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
      
    }
}
