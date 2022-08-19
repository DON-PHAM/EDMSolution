using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class AppPermission
    {
        public long Id { set; get; }
        public string IdRole { set; get; }
        public long IdModuleFunction { set; get; }
        public Nullable<long> MaDonViSuDung { set; get; }
    }
}
