using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Product
    {
        public int ID { set; get; }
        public string Code { set; get; }
        public decimal PromationPrice { set; get; }
        public bool IncludedVAT { set; get; }
        public int Quantity { set; get; }
        public int CategoryID { set; get; }
        public string Detail { set; get; }
        public int Warranty { set; get; }
        public decimal Price { set; get; }
        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime ModifiedDate { set; get; }
        public string ModifiedBy { set; get; }
        public Status Status { set; get; }
        public int ViewCount { set; get; }
        public DateTime TopHot { set; get; }
        public List<ProductTranslation> ProductTranslations { set; get; }
        public List<Cart> Carts { set; get; }
        public List<OrderDetail> OrderDetails { set; get; }
        public ProductCategory ProductCategory { set; get; }
        public List<ProductImage> ProductImages { set; get; }

    }
}
