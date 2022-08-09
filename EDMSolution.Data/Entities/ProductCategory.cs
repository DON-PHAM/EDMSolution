using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class ProductCategory
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public int ParentId { set; get; }
        public int DisplayOrder { set; get; }
        public string SeoTitle { set; get; }
        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime ModifiedDate { set; get; }
        public string ModifiedBy { set; get; }
        public string MetaKeywords { set; get; }
        public string MetaDescription { set; get; }
        public Status Status { set; get; }
    }
}
