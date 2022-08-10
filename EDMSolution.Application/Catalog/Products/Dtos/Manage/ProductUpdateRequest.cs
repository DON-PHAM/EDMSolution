using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Application.Catalog.Products.Dtos
{
    public class ProductUpdateRequest
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public string Description { set; get; }
        public string MetaKeywords { set; get; }
        public string MetaDescription { set; get; }
        public string LanguageID { set; get; }


    }
}
