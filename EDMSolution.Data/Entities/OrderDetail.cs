using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class OrderDetail
    {
        public int ID { set; get; }
        public  int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public Order Order { set; get; }
        public Product Product { set; get; }
    }
}
