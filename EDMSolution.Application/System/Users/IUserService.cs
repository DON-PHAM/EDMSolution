using EDMSolution.Data.Enums;
using EDMSolution.ViewModels;
using EDMSolution.ViewModels.Common;
using EDMSolution.ViewModels.System.Users;
using EDMSolution.ViewModels.System.Users.Request;
using EDMSolution.ViewModels.System.Users.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<UserVm>> Authencate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);

        Task<ApiResult<PagedResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request);

        Task<ApiResult<UserVm>> GetById(Guid id, long dvsdId);

       // Task<ApiResult<bool>> Delete(DeleteAllUserRequest request);
        Task<ApiResult<bool>> ChangeStatus(string id, Status status, string UserName);
    }
}
