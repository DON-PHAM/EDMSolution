using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    //Chuc Nang
    public class AppFunction
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public Status Status { set; get; }
        public Nullable<long> MaDonViSuDung { set; get; }
    }
}
