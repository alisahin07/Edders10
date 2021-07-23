using Business.Concrete;
using DataAcess.Concrete.EntityFrameWork;
using Entity.Concrete;
using System;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
           
            //CategoryTest();
        }

         
        private static void CategoryTest()
        {
            CategoryManager _category = new CategoryManager(new EfCategoryDal());
            foreach (var _cat in _category.GetAll())
            {
                Console.WriteLine(_cat.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager _product = new ProductManager(new EfProductDal());

            foreach (var item in _product.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
