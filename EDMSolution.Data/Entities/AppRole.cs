using EDMSolution.Data.Enums;
using EDMSolution.Utilities.Contants;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
        public Nullable<Guid> IdParent { get; set; }
        public UnitRole RoleType { get; set; }
        public Status Status { get; set; }
        public StatusDelete IsDelete { get; set; }
        public string UserCreate { get; set; }
        public Nullable<DateTime> DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public Nullable<DateTime> DateUpdate { get; set; }
        public Nullable<long> MaDonViSuDung { get; set; }

    }
}
