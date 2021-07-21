using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dtos
{
   public class ProductDetailDTO: IDTO
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
    }
}
