using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDMSolution.Data.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appconfigs",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaDonViSuDung = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appconfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AppFunctions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MaDonViSuDung = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFunctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppModuleFunctions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdModule = table.Column<long>(type: "bigint", nullable: false),
                    IdFunction = table.Column<long>(type: "bigint", nullable: false),
                    MaDonViSuDung = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppModuleFunctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppModules",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Controller = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Action = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Index = table.Column<int>(type: "int", nullable: false),
                    IdParent = table.Column<long>(type: "bigint", nullable: false),
                    MaDonViSuDung = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPermissions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdModuleFunction = table.Column<long>(type: "bigint", nullable: false),
                    MaDonViSuDung = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    IdParent = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoleType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaDonViSuDung = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Avata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    MaDonViSuDung = table.Column<long>(type: "bigint", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "DonViSuDung_Modules",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonViSuDungId = table.Column<long>(type: "bigint", nullable: false),
                    ModuleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonViSuDung_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    MaDonViSuDung = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_DonViSuDungs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDonViSuDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenMienRieng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenMienCon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favicon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Banner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_DonViSuDungs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppFunctions",
                columns: new[] { "Id", "MaDonViSuDung", "Name", "Status" },
                values: new object[,]
                {
                    { 6L, null, "Gửi duyệt", 1 },
                    { 1L, null, "Xem", 1 },
                    { 2L, null, "Tạo", 1 },
                    { 3L, null, "Sửa", 1 },
                    { 4L, null, "Xóa", 1 },
                    { 5L, null, "Thay dổi trạng thái", 1 },
                    { 7L, null, "Duyệt", 1 }
                });

            migrationBuilder.InsertData(
                table: "AppModuleFunctions",
                columns: new[] { "Id", "IdFunction", "IdModule", "MaDonViSuDung" },
                values: new object[,]
                {
                    { 7L, 2L, 2L, 1L },
                    { 9L, 4L, 2L, 1L },
                    { 10L, 5L, 2L, 1L },
                    { 11L, 1L, 3L, 1L },
                    { 13L, 3L, 3L, 1L },
                    { 6L, 1L, 2L, 1L },
                    { 14L, 4L, 3L, 1L },
                    { 15L, 5L, 3L, 1L },
                    { 12L, 2L, 3L, 1L },
                    { 5L, 5L, 1L, 1L },
                    { 8L, 3L, 2L, 1L },
                    { 3L, 3L, 1L, 1L },
                    { 2L, 2L, 1L, 1L },
                    { 1L, 1L, 1L, 1L },
                    { 4L, 4L, 1L, 1L }
                });

            migrationBuilder.InsertData(
                table: "AppModules",
                columns: new[] { "Id", "Action", "Controller", "Icon", "IdParent", "Index", "MaDonViSuDung", "Name", "Status" },
                values: new object[,]
                {
                    { 3L, "Index", "sysRole", "icon-qlvaitro", 1L, 5, null, "Quản lí vai trò", 1 },
                    { 2L, "Index", "sysUser", "icon-qltaikhoan", 1L, 3, null, "Quản lí tài khoản", 1 },
                    { 1L, "", "", "icon-chucnangchung", 0L, 0, null, "Chức năng chung", 1 }
                });

            migrationBuilder.InsertData(
                table: "AppPermissions",
                columns: new[] { "Id", "IdModuleFunction", "IdRole", "MaDonViSuDung" },
                values: new object[,]
                {
                    { 11L, 11L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 10L, 10L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 9L, 9L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 8L, 8L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 7L, 7L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 6L, 6L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 5L, 5L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 2L, 2L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 3L, 3L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 1L, 1L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 15L, 15L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 14L, 14L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 12L, 12L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 4L, 4L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L },
                    { 13L, 13L, "8d04dce2-969a-435d-bba4-df3f325983dc", 1L }
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreate", "DateUpdate", "Description", "IdParent", "IsDelete", "MaDonViSuDung", "Name", "NormalizedName", "RoleType", "Status", "UserCreate", "UserUpdate" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "4b6402a2-1867-4625-8f82-5f3c022c865e", new DateTime(2022, 8, 20, 0, 57, 5, 238, DateTimeKind.Local).AddTicks(4296), null, "Administrator role", null, 0, 1L, "admin", "admin", 1, 1, null, null });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avata", "ConcurrencyStamp", "DateCreate", "DateUpdate", "Dob", "Email", "EmailConfirmed", "FullName", "IsDelete", "LockoutEnabled", "LockoutEnd", "MaDonViSuDung", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "Status", "TwoFactorEnabled", "UserCreate", "UserName", "UserUpdate" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, null, "26c24cc4-183f-4b5a-8342-c46793d2f5d1", null, null, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", true, "Dang Dinh Lam", 0, false, null, 1L, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEJ9bMmWh+ZUv3JEnWuUBTNt2hGUKwyK/avoQga8mEt+nAnWlIKgH84ouYw+zs0bBug==", null, false, "8d04dce2-969a-435d-bba4-df3f325983dc", "", 1, false, null, "admin", null });

            migrationBuilder.InsertData(
                table: "Appconfigs",
                columns: new[] { "Key", "MaDonViSuDung", "Value" },
                values: new object[,]
                {
                    { "HomeDescription", 1L, "This is description of DPISolution" },
                    { "HomeKeyword", 1L, "This is keyword of DPISolution" },
                    { "HomeTitle", 1L, "This is home page of DPISolution" }
                });

            migrationBuilder.InsertData(
                table: "DonViSuDung_Modules",
                columns: new[] { "Id", "DonViSuDungId", "ModuleId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L },
                    { 2L, 1L, 2L },
                    { 3L, 1L, 3L }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "MaDonViSuDung", "Name" },
                values: new object[,]
                {
                    { "vi", true, 1L, "Tiếng Việt" },
                    { "en", false, 1L, "English" }
                });

            migrationBuilder.InsertData(
                table: "Tb_DonViSuDungs",
                columns: new[] { "Id", "Banner", "DateCreate", "DateUpdate", "DiaChi", "Email", "Favicon", "IsDelete", "Logo", "SoDienThoai", "Status", "TenDonViSuDung", "TenMienCon", "TenMienRieng", "UserCreate", "UserUpdate" },
                values: new object[] { 1L, null, null, null, "test", "test@gmail.com.vn", null, 0, null, "0987654321", 1, "Sở kế hoạch và đầu tư", "https://localhost:5002", "https://localhost:5002", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appconfigs");

            migrationBuilder.DropTable(
                name: "AppFunctions");

            migrationBuilder.DropTable(
                name: "AppModuleFunctions");

            migrationBuilder.DropTable(
                name: "AppModules");

            migrationBuilder.DropTable(
                name: "AppPermissions");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "DonViSuDung_Modules");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Tb_DonViSuDungs");
        }
    }
}
