using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order
    {
        public int Id { get; set; }
        public List<ProductOrder> Products { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
