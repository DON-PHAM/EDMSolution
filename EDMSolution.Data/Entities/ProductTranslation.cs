using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class ProductTranslation
    {
        public int ID { set; get; }
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
