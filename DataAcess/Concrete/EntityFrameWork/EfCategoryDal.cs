using Core.DataAcess;
using DataAcess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Concrete.EntityFrameWork
{
   public class EfCategoryDal: RepositoryBase<Category,NortwindContext>,ICategoryDal
    {
    }
}
