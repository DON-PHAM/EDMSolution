using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class AppModule
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Controller { set; get; }
        public string Action { set; get; }
        public string Icon { set; get; }
        public Status Status { set; get; }
        public int Index { set; get; }
        public long IdParent { set; get; }
        public Nullable<long> MaDonViSuDung { set; get; }
    }
}
