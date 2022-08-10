using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class VisitorStatistic
    {
        public int ID { set; get; }
        public DateTime VistedDate { set; get; }
        public string IPAddress { set; get; }
    }
}
