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
    public class ConfigTimeReportService : IConfigTimeReportService
    {
        public Task<ApiResult<ConfigTimeReportVm>> GetConfigTimeReport()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> Save(ConfigTimeReportRequest configTimeReportRequest)
        {
            throw new NotImplementedException();
        }
    }
}
