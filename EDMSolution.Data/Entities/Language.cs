using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Language
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public bool IsDefault { set; get; }
    }
}
