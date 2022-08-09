using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Feedback
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Phone { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Contents { set; get; }
        public DateTime CreatedDate { set; get; }
        public Status Status { set; get; }
    }
}
