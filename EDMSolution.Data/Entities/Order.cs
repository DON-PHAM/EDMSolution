using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Order
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Message { set; get; }
        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public string PaymenMethod { set; get; }
        public string PaymentStatus { set; get; }
        public Status Status { set; get; }
        
        
        public List<Order> Orders { set;get }
    }
}
