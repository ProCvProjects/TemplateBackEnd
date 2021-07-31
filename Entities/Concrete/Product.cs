using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public string ProductBrand { get; set; }
        public List<ProductOrder> Orders { get; set; }
    }
}
