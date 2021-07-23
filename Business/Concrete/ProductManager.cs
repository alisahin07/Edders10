using Business.Abstract;
using DataAcess.Abstract;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _product;

        public ProductManager(IProductDal product)
        {
            _product = product;
        }

        public void Add(Product product)
        {
         

            _product.Add(product);
             
        }

        public  List<Product> GetAll()
        {

            return _product.GetAll();
        }

        public List<ProductDetailDTO> GetProductDetail()
        {
            return _product.GetProductDetail();
        }
    }
}
