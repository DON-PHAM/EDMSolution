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
    public class RoleService : IRoleService
    {
        public Task<ApiResult<bool>> Create(CreateRoleRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> Delete(string Id, string UserName)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<List<RoleVm>>> GetAll(long Madonvisudung)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<RoleVm>> GetById(string id, long Madonvisudung)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<List<PermissionVm>>> GetFunctionByRoleId(string RoleId, long Madonvisudung)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<List<PermissionVm>>> GetFunctionByUnit(string UserId, string Controler, long Madonvisudung)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<List<ModuleVm>>> GetModun(long Madonvisudung)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<List<ModuleVm>>> GetModunByUnit(string UserId, long Madonvisudung)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<ViewModels.PagedResult<RoleVm>>> Getpaging(PagingRoleRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> Update(string Id, CreateRoleRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
