using EDMSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public string RoleId { get; set; }
        public DateTime Dob { get; set; }
        public string Avata { get; set; }
        public Status Status { get; set; }
        public string UserCreate { get; set; }
        public Nullable<DateTime> DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public Nullable<DateTime> DateUpdate { get; set; }
        public StatusDelete IsDelete { get; set; }
        public Nullable<long> MaDonViSuDung { get; set; }
    }
}
