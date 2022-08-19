using EDMSolution.Data.EF;
using EDMSolution.Data.Entities;
using EDMSolution.Data.Enums;
using EDMSolution.Utilities.Contants;
using EDMSolution.Utilities.Exceptions;
using EDMSolution.ViewModels;
using EDMSolution.ViewModels.Common;
using EDMSolution.ViewModels.System.Users;
using EDMSolution.ViewModels.System.Users.Request;
using EDMSolution.ViewModels.System.Users.Response;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;
        public readonly EDMDbContext _context;
        public UserService(EDMDbContext context, UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _context = context;
        }
        public async Task<ApiResult<UserVm>> Authencate(LoginRequest request)
        {
            try
            {
                var domain = await _context.Tb_DonViSuDungs.FirstAsync(x => x.TenMienRieng.Contains(request.Domain));
                var user = _userManager.Users.First(x => x.UserName.Trim().ToUpper() == request.UserName.Trim().ToUpper() && x.MaDonViSuDung == domain.Id);
                if (user == null) return new ApiErrorResult<UserVm>("Tài khoản không tồn tại");

                if (user.Status != Status.Active)
                {
                    return new ApiErrorResult<UserVm>("Tài khoản chưa được kích hoạt");
                }
                var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
                if (!result.Succeeded)
                {
                    return new ApiErrorResult<UserVm>("Mật khẩu không đúng");
                }

                var claims = new[]
                {
                new Claim(type:"UserId",user.Id.ToString()),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.FullName),
                new Claim(type: "UserId", value: user.Id.ToString()),
                new Claim(type: "RoleId", value: user.RoleId.ToString()),
                new Claim(type: "Avata", (user.Avata != null ? user.Avata: "")),
                new Claim(type: "DomainId", domain.Id.ToString()),
                new Claim(ClaimTypes.Name, request.UserName)
            };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                    _config["Tokens:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(3),
                    signingCredentials: creds);
                var _res = new UserVm()
                {
                    FullName = user.FullName,
                    Token = new JwtSecurityTokenHandler().WriteToken(token)
                };
                return new ApiSuccessResult<UserVm>(_res);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<UserVm>(ex.Message);
            }

        }
        public Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<PagedResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<UserVm>> GetById(Guid id, long dvsdId)
        {
            throw new NotImplementedException();
        }

        //public Task<ApiResult<bool>> Delete(DeleteAllUserRequest request)
        //{
        //    throw new NotImplementedException();
        //}

        public Task<ApiResult<bool>> ChangeStatus(string id, Status status, string UserName)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(request.UserName);
                if (user != null)
                {
                    return new ApiErrorResult<bool>("Tài khoản đã tồn tại");
                }
                if (await _userManager.FindByEmailAsync(request.Email) != null)
                {
                    return new ApiErrorResult<bool>("Emai đã tồn tại");
                }

                user = new AppUser()
                {
                    Dob = request.Dob,
                    Email = request.Email,
                    FullName = request.FullName,
                    UserName = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    RoleId = request.RoleId,
                    Avata = request.Avata,
                    DateCreate = DateTime.Now,
                    UserCreate = request.UserName,
                    MaDonViSuDung = request.MaDonViSuDung

                };
                var result = await _userManager.CreateAsync(user, SystemContants.AppSettings.Passdefault);
                if (result.Succeeded)
                {
                    return new ApiSuccessResult<bool>();
                }
                return new ApiErrorResult<bool>("Đăng ký không thành công");
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<bool>(ex.Message);
            }
        }
    }
}
