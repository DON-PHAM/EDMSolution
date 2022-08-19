using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Enums
{
    public enum Status
    {
        InActive,
        Active
    }
    public enum StatusDelete
    {
        NA,
        Delete
    }
    public enum PlanStatus
    {
        Draft,
        Wait,
        Reject,
        Complete,
        NotComplete
    }
    public enum ReportStatus
    {
        Draft, //Lưu nháp
        Wait, // Chờ duyệt
        Appoved, // Đã duyệt
        Reject, // Từ chối
        Complete // Hoành thành
    }
}
