﻿using EDMSolution.Data.Configurations;
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
            modelBuilder.ApplyConfiguration(new AppConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CategogryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());

            modelBuilder.Entity<IdentityUserClaim <Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole <Guid>>().ToTable("AppUserRoles").HasKey(x=>new { x.UserId,x.RoleId});
            modelBuilder.Entity<IdentityUserLogin <Guid>>().ToTable("AppUserLogins").HasKey(x=>x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x=>x.UserId);
            //Data Seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<About> Abouts;
        public DbSet<AppConfig> AppConfigs;
        public DbSet<AppRole> AppRoles;
        public DbSet<AppUser> AppUsers;
        public DbSet<Cart> Carts;
        public DbSet<CategoryTranslation> CategoryTranslations;
        public DbSet<Contact> Contacts;
        public DbSet<Feedback> Feedbacks;
        public DbSet<Footer> Footers;
        public DbSet<Language> Languages;
        public DbSet<Menu> Menus;
        public DbSet<MenuType> MenuTypes;
        public DbSet<Order> Orders;
        public DbSet<OrderDetail> OrderDetails;
        public DbSet<Post> Posts;
        public DbSet<PostTag> PostTags;
        public DbSet<Product> Products;
        public DbSet<ProductCategory> ProductCategories;
        public DbSet<ProductTranslation> ProductTranslations;
        public DbSet<Promotion> Promotions;
        public DbSet<Slide> Slides;
        public DbSet<Tag> Tags;
        public DbSet<Transaction> Transactions;
    }
}