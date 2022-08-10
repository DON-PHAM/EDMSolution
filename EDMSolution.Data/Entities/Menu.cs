using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Menu
    {
        public int ID { set; get; }
        public string Link { set; get; }
        public int DisplayOrder { set; get; }
        public string Target { set; get; }
        public Status Status { set; get; }
        public int TypeID { set; get; }
        public List<MenuTranslation> MenuTranslations;
        public MenuType MenuType { set; get; }
    }
}
