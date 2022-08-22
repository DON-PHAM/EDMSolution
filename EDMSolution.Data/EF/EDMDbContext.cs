using EDMSolution.Data.Configurations;
using EDMSolution.Data.Entities;
using EDMSolution.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.EF
{
    public class EDMDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public EDMDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Config using Fluent API
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AppFunctionConfiguration());
            modelBuilder.ApplyConfiguration(new AppModuleConfiguration());
            modelBuilder.ApplyConfiguration(new AppModuleFunctionConfiguration());
            modelBuilder.ApplyConfiguration(new AppPermissionConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new DonViSuDung_ModuleConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguraion());
            modelBuilder.ApplyConfiguration(new Tb_DonViSuDungConfiguration());
            

            modelBuilder.Entity<IdentityUserClaim <Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole <Guid>>().ToTable("AppUserRoles").HasKey(x=>new { x.UserId,x.RoleId});
            modelBuilder.Entity<IdentityUserLogin <Guid>>().ToTable("AppUserLogins").HasKey(x=>x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x=>x.UserId);
            //Data Seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<AppFunction> AppFunctions { get; set; }
        public DbSet<AppModule> AppModules { get; set; }
        public DbSet<AppModuleFunction> ModuleFunctions { get; set; }
        public DbSet<AppPermission> AppPermissions { get; set; }
        public DbSet<DonViSuDung_Module> DonViSuDung_Modules { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Tb_DonViSuDung> Tb_DonViSuDungs { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
