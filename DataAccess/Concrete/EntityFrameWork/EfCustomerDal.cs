using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFrameWork.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>,ICustomerDal
    {
    }
}
