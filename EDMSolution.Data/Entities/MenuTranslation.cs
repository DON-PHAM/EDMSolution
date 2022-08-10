using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class MenuTranslation
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int MenuID { set; get; }
        public int LanguageID { set; get; }
        public Menu Menu { set; get; }
        public Language Language { set; get; }
    }
}
