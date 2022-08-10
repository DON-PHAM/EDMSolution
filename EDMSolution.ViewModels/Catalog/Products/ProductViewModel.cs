using EDMSolution.Data.Entities;
using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.ViewModels
{
    public class ProductViewModel
    {
        public int ID { set; get; }
        public string Code { set; get; }
        public string Image { set; get; }
        public string MoreImage { set; get; }
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
        public int ProductID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public string Description { set; get; }
        public string MetaKeywords { set; get; }
        public string MetaDescription { set; get; }
        public int LanguageID { set; get; }
        public Product Product { set; get; }
        public Language Language { set; get; }
    }
}
