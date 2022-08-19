using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class AppModuleFunction
    {
        public long Id { set; get; }
        public long IdModule { set; get; }
        public long IdFunction { set; get; }
        public Nullable<long> MaDonViSuDung { set; get; }
    }
}
