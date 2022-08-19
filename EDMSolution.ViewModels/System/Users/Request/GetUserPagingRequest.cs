using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.ViewModels.System.Users.Request
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string name { get; set; }
        public string role { get; set; }
        public long MaDonViSuDung { get; set; }
    }
}
