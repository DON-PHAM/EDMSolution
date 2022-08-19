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
            
            

            modelBuilder.Entity<IdentityUserClaim <Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole <Guid>>().ToTable("AppUserRoles").HasKey(x=>new { x.UserId,x.RoleId});
            modelBuilder.Entity<IdentityUserLogin <Guid>>().ToTable("AppUserLogins").HasKey(x=>x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x=>x.UserId);
            //Data Seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<AppConfig> AppConfigs;
        public DbSet<AppFunction> AppFunctions;
        public DbSet<AppModule> AppModules;
        public DbSet<AppModuleFunction> ModuleFunctions;
        public DbSet<AppPermission> AppPermissions;
        public DbSet<DonViSuDung_Module> DonViSuDung_Modules;
        public DbSet<Language> Languages;
        public DbSet<Tb_DonViSuDung> Tb_DonViSuDungs;
        public DbSet<AppRole> AppRoles;
        public DbSet<AppUser> AppUsers;
        
    }
}
