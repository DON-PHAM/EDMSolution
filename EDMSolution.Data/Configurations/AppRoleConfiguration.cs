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
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRoles");
            builder.Property(x => x.Name).HasMaxLength(255);
            builder.Property(x => x.Description).IsRequired(false).HasMaxLength(5000);
            builder.Property(x => x.IdParent).IsRequired(false);
            builder.Property(x => x.DateCreate).IsRequired(false);
            builder.Property(x => x.DateUpdate).IsRequired(false);
        }
    }
}
