using EDMSolution.ViewModels;
using EDMSolution.ViewModels.Common;
using EDMSolution.ViewModels.System.Roles.Requests;
using EDMSolution.ViewModels.System.Roles.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Application.System.Roles
{
    public interface IRoleService
    {
        Task<ApiResult<PagedResult<RoleVm>>> Getpaging(PagingRoleRequest request);
        Task<ApiResult<List<RoleVm>>> GetAll(long Madonvisudung);
        Task<ApiResult<RoleVm>> GetById(string id, long Madonvisudung);

        Task<ApiResult<bool>> Create(CreateRoleRequest request);

        Task<ApiResult<bool>> Update(string Id, CreateRoleRequest request);

        Task<ApiResult<bool>> Delete(string Id, string UserName);

        //Task<ApiResult<bool>> DeleteAll(DeleteAllUserRequest request);

        Task<ApiResult<List<ModuleVm>>> GetModun(long Madonvisudung);
        Task<ApiResult<List<ModuleVm>>> GetModunByUnit(string UserId, long Madonvisudung);
        Task<ApiResult<List<PermissionVm>>> GetFunctionByUnit(string UserId, string Controler, long Madonvisudung);
        Task<ApiResult<List<PermissionVm>>> GetFunctionByRoleId(string RoleId, long Madonvisudung);
    }
}
