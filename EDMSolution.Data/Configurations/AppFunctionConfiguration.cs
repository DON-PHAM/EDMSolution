using EDMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Configurations
{
    public class AppFunctionConfiguration : IEntityTypeConfiguration<AppFunction>
    {
        public void Configure(EntityTypeBuilder<AppFunction> builder)
        {
            builder.ToTable("AppFunctions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(200);
        }
    }
}
