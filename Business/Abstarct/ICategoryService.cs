using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstarct
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
