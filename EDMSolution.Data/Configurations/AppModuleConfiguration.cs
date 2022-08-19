﻿using EDMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Configurations
{
    public class AppModuleConfiguration : IEntityTypeConfiguration<AppModule>
    {
        public void Configure(EntityTypeBuilder<AppModule> builder)
        {
            builder.ToTable("AppModules");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Controller).HasMaxLength(200);
            builder.Property(x => x.Action).HasMaxLength(200);
            builder.Property(x => x.Icon).HasMaxLength(50);

        }
    }
}
