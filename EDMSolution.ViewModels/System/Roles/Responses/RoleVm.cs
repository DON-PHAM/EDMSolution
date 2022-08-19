using EDMSolution.Data.Entities;
using EDMSolution.Data.Enums;
using EDMSolution.Utilities.Contants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.ViewModels.System.Roles.Responses
{
    public class RoleVm
    {
        public Guid Id { get; set; }
        [Display(Name = "Tên vai trò")]
        public string Name { get; set; }
        [Display(Name = "Loại vai trò")]
        public UnitRole RoleType { get; set; }
        [Display(Name = "Trạng thái")]
        public Status status { get; set; }
        public Nullable<Guid> ParentId { get; set; }
        public int level { get; set; }
        public List<AppPermission> Permission { get; set; }
    }
}
