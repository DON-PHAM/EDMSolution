using EDMSolution.ViewModels.Common;
using EDMSolution.ViewModels.System.ConfigTimeReport;
using EDMSolution.ViewModels.System.ConfigTimeReport.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Application.System.ConfigTimeReport
{
    public interface IConfigTimeReportService
    {
        Task<ApiResult<ConfigTimeReportVm>> GetConfigTimeReport();

        Task<ApiResult<bool>> Save(ConfigTimeReportRequest configTimeReportRequest);
    }
}
