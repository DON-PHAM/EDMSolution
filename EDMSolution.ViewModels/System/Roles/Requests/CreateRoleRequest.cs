using EDMSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.ViewModels.System.Roles.Requests
{
    public class CreateRoleRequest
    {
        public Nullable<Guid> Id { get; set; }
        [Display(Name = "Tên vai trò")]
        public string Name { get; set; }
        [Display(Name = "Loại vai trò")]
        public int RoleType { get; set; }
        [Display(Name = "Vai trò đơn vị")]
        public Nullable<Guid> ParentId { get; set; }
        public List<AppPermission> Permission { get; set; }
        public string UserName { get; set; }
        public long MaDonViSuDung { get; set; }
    }
}
