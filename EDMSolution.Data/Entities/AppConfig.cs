using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class AppConfig
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Type { set; get; }
        public string Value { set; get; }
        public Status Status { set; get; }
    }
}
