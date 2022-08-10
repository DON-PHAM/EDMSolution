using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Category
    {
        public int ID { set; get; }
        public int ParentId { set; get; }
        public int DisplayOrder { set; get; }
        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime ModifiedDate { set; get; }
        public string ModifiedBy { set; get; }
        public Status Status { set; get; }
        public List<CategoryTranslation> CategoryTranslations;
    }
}
