using Core.DataAcess;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Abstract
{
   public interface IProductDal:IRepository<Product>
    {
        List<ProductDetailDTO>GetProductDetail();
    }
}
