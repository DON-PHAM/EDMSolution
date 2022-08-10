using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class ProductImage
    {
        public int ID { set; get; }
        public int ProductID { set; get; }
        public string ImagPath { set; get; }
        public string Caption { set; get; }
        public bool IsDefault { set; get; }
        public DateTime CreatedDate { set; get; }
        public int SortOrder { set; get; }
        public int FileSize { set; get; }
        public Product Product { set; get; }
    }
}
