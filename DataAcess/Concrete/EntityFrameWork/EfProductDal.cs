using Core.DataAcess;
using DataAcess.Abstract;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcess.Concrete.EntityFrameWork
{
    public class EfProductDal : RepositoryBase<Product, NortwindContext>, IProductDal
    {
        public List<ProductDetailDTO> GetProductDetail()
        {
            using (NortwindContext context = new NortwindContext() )
            {
                var result = from c in context.Categories
                             join p in context.Products
                             on c.CategoryId equals p.CategoryId
                             select new ProductDetailDTO { ProductId=p.ProductId, CategoryId=c.CategoryId,
                             CategoryName=c.CategoryName, ProductName=p.ProductName};
                return result.ToList();
                            
            }
        }
    }
}
