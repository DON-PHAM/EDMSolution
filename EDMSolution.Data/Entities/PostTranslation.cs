using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class PostTranslation
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int PostID { set; get; }
        public string Description { set; get; }
        public string Detail { set; get; }
        public string MetaKeywords { set; get; }
        public string MetaDescription { set; get; }
        public string LanguageCode { set; get; }
        public Post Post { set; get; }
    }
}
