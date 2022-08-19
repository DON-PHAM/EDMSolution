using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Tb_DonViSuDung
    {
        public long Id { get; set; }
        public string TenDonViSuDung { get; set; }
        public string DiaChi { get; set; }
        public string TenMienRieng { get; set; }
        public string TenMienCon { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string Logo { get; set; }
        public string Favicon { get; set; }
        public string Banner { get; set; }
        public Status Status { get; set; }
        public string UserCreate { get; set; }
        public Nullable<DateTime> DateCreate { get; set; }
        public string UserUpdate { get; set; }
        public Nullable<DateTime> DateUpdate { get; set; }
        public StatusDelete IsDelete { get; set; }
    }
}
