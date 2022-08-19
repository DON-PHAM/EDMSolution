using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.ViewModels.System.Roles.Responses
{
    public class PermissionVm
    {
        public long IdModuleFunction { get; set; }
        //ten thao tac
        public long FunctionId { get; set; }
        public string FunctionName { get; set; }
        public Nullable<bool> ischeck { get; set; }
    }
}
