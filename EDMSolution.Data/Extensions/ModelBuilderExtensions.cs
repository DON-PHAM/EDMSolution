using EDMSolution.Data.Entities;
using EDMSolution.Data.Enums;
using EDMSolution.Utilities.Contants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tb_DonViSuDung>().HasData(
                new Tb_DonViSuDung()
                {
                    Id = 1,
                    TenDonViSuDung = "Sở kế hoạch và đầu tư",
                    DiaChi = "test",
                    TenMienRieng = "https://localhost:5002",
                    TenMienCon = "https://localhost:5002",
                    Email = "test@gmail.com.vn",
                    SoDienThoai = "0987654321",
                    Status = Status.Active
                });
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of DPISolution", MaDonViSuDung = 1 },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of DPISolution", MaDonViSuDung = 1 },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of DPISolution", MaDonViSuDung = 1 }
               );

            modelBuilder.Entity<Language>().HasData(
               new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true, MaDonViSuDung = 1 },
               new Language() { Id = "en", Name = "English", IsDefault = false, MaDonViSuDung = 1 });
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role",
                RoleType = UnitRole.DonVi,
                Status = Status.Active,
                IsDelete = StatusDelete.NA,
                DateCreate = DateTime.Now,
                MaDonViSuDung = 1
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tedu.international@gmail.com",
                NormalizedEmail = "tedu.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FullName = "Dang Dinh Lam",
                Dob = new DateTime(2020, 01, 31),
                MaDonViSuDung = 1,
                RoleId = roleId.ToString(),
                Status = Status.Active
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<AppModule>().HasData(

                new AppModule() { Id = 1, Name = "Chức năng chung", Controller = "", Action = "", Icon = "icon-chucnangchung", Status = Status.Active, Index = 0, IdParent = 0 },
                new AppModule() { Id = 2, Name = "Quản lí tài khoản", Controller = "sysUser", Action = "Index", Icon = "icon-qltaikhoan", Status = Status.Active, Index = 3, IdParent = 1 },
                new AppModule() { Id = 3, Name = "Quản lí vai trò", Controller = "sysRole", Action = "Index", Icon = "icon-qlvaitro", Status = Status.Active, Index = 5, IdParent = 1 }
                   );
            modelBuilder.Entity<AppFunction>().HasData(
               new AppFunction { Id = 1, Name = "Xem", Status = Status.Active },
               new AppFunction { Id = 2, Name = "Tạo", Status = Status.Active },
               new AppFunction { Id = 3, Name = "Sửa", Status = Status.Active },
               new AppFunction { Id = 4, Name = "Xóa", Status = Status.Active },
               new AppFunction { Id = 5, Name = "Thay dổi trạng thái", Status = Status.Active },
               new AppFunction { Id = 6, Name = "Gửi duyệt", Status = Status.Active },
               new AppFunction { Id = 7, Name = "Duyệt", Status = Status.Active }
               );
            modelBuilder.Entity<AppModuleFunction>().HasData(
            #region chuc nang




                //Quản lý chung
                new AppModuleFunction { Id = 1, IdModule = 1, IdFunction = 1, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 2, IdModule = 1, IdFunction = 2, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 3, IdModule = 1, IdFunction = 3, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 4, IdModule = 1, IdFunction = 4, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 5, IdModule = 1, IdFunction = 5, MaDonViSuDung = 1 },

                //Quản lí tài khoản
                new AppModuleFunction { Id = 6, IdModule = 2, IdFunction = 1, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 7, IdModule = 2, IdFunction = 2, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 8, IdModule = 2, IdFunction = 3, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 9, IdModule = 2, IdFunction = 4, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 10, IdModule = 2, IdFunction = 5, MaDonViSuDung = 1 },


                //Quản lí vai trò
                new AppModuleFunction { Id = 11, IdModule = 3, IdFunction = 1, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 12, IdModule = 3, IdFunction = 2, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 13, IdModule = 3, IdFunction = 3, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 14, IdModule = 3, IdFunction = 4, MaDonViSuDung = 1 },
                new AppModuleFunction { Id = 15, IdModule = 3, IdFunction = 5, MaDonViSuDung = 1 }

                #endregion chuc nang
                );
            modelBuilder.Entity<AppPermission>().HasData(
                //Ke hoach phat trien
                new AppPermission { Id = 1, IdRole = roleId.ToString(), IdModuleFunction = 1, MaDonViSuDung = 1 },
                new AppPermission { Id = 2, IdRole = roleId.ToString(), IdModuleFunction = 2, MaDonViSuDung = 1 },
                new AppPermission { Id = 3, IdRole = roleId.ToString(), IdModuleFunction = 3, MaDonViSuDung = 1 },
                new AppPermission { Id = 4, IdRole = roleId.ToString(), IdModuleFunction = 4, MaDonViSuDung = 1 },
                new AppPermission { Id = 5, IdRole = roleId.ToString(), IdModuleFunction = 5, MaDonViSuDung = 1 },
                new AppPermission { Id = 6, IdRole = roleId.ToString(), IdModuleFunction = 6, MaDonViSuDung = 1 },
                new AppPermission { Id = 7, IdRole = roleId.ToString(), IdModuleFunction = 7, MaDonViSuDung = 1 },
                new AppPermission { Id = 8, IdRole = roleId.ToString(), IdModuleFunction = 8, MaDonViSuDung = 1 },
                new AppPermission { Id = 9, IdRole = roleId.ToString(), IdModuleFunction = 9, MaDonViSuDung = 1 },
                new AppPermission { Id = 10, IdRole = roleId.ToString(), IdModuleFunction = 10, MaDonViSuDung = 1 },
                new AppPermission { Id = 11, IdRole = roleId.ToString(), IdModuleFunction = 11, MaDonViSuDung = 1 },
                new AppPermission { Id = 12, IdRole = roleId.ToString(), IdModuleFunction = 12, MaDonViSuDung = 1 },
                new AppPermission { Id = 13, IdRole = roleId.ToString(), IdModuleFunction = 13, MaDonViSuDung = 1 },
                new AppPermission { Id = 14, IdRole = roleId.ToString(), IdModuleFunction = 14, MaDonViSuDung = 1 },
                new AppPermission { Id = 15, IdRole = roleId.ToString(), IdModuleFunction = 15, MaDonViSuDung = 1 }
                );
            modelBuilder.Entity<DonViSuDung_Module>().HasData(
                new DonViSuDung_Module { Id = 1, DonViSuDungId = 1, ModuleId = 1 },
                new DonViSuDung_Module { Id = 2, DonViSuDungId = 1, ModuleId = 2 },
                new DonViSuDung_Module { Id = 3, DonViSuDungId = 1, ModuleId = 3 }
                );
        }
    }
}
