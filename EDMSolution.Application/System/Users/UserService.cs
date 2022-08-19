using EDMSolution.Data.EF;
using EDMSolution.Data.Entities;
using EDMSolution.Data.Enums;
using EDMSolution.Utilities.Exceptions;
using EDMSolution.ViewModels.Common;
using EDMSolution.ViewModels.System.Users;
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
        public async Task<ApiResult<string>> Authencate(LoginRequest request)
        {
            try
            {
                var domain = await _context.Tb_DonViSuDungs.FirstAsync(x => x.TenMienRieng == request.Domain);
                var user = await _userManager.Users.FirstAsync(x => x.UserName.Trim().ToUpper() == request.UserName.Trim().ToUpper() && x.MaDonViSuDung == domain.Id);
                if (user == null) return new ApiErrorResult<string>("Tài khoản không tồn tại");
                if(user.Status != Status.Active)
                {
                    return new ApiErrorResult<string>("Tài khoản chưa được kích hoạt");
                }
                var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
                
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
                
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var user = new AppUser() { 
                Dob = request.Dob,
                Email = request.Email,
                FirstName = request.FirstName,
                UserName = request.UserName,
                
            };
            var result = await _userManager.CreateAsync(user, request.UserName);
            if(result.Succeeded)
            {
                return true;
            }
            return false;
        }

    }
}
