using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.ViewModels.System.Roles.Requests
{
    public class PagingRoleRequest : PagingRequestBase
    {
        public string Name { get; set; }
        public int? RoleType { get; set; }
        public int? Status { get; set; }
        public long MaDonViSuDung { get; set; }
    }
}
