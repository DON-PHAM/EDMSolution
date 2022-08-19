using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.ViewModels.System.Roles.Responses
{
    public class  ModuleVm
    {
        public long ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Icon { get; set; }
        public int Index { get; set; }
        public long ModuleParentId { get; set; }
        //
        public List<PermissionVm> Permission { get; set; }
    }
}
