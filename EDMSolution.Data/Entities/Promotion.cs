using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Promotion
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public bool ApplyForAll { set; get; }
        public int DiscountPercent { set; get; }
        public int DiscountAmount { set; get; }
        public int ProductID { set; get; }
        public int ProductCategoryID { set; get; }
        public Status Status { set; get; }
    }
}
