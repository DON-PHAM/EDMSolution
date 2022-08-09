using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.EF
{
    public class EDMSolutionDbContextFactory : IDesignTimeDbContextFactory<EDMDbContext>
    {
        //Viết ra để sử dụng cho mục đích tạo Migration 
        public EDMDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();
            var connectionString = configuration.GetConnectionString("EDMSolutionDb");
            var optionsBuilder = new DbContextOptionsBuilder<EDMDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new EDMDbContext(optionsBuilder.Options);
        }
    }
}
