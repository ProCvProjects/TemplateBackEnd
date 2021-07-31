using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductOrder
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
    }
}
