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
    public class DonViSuDung_ModuleConfiguration : IEntityTypeConfiguration<DonViSuDung_Module>
    {
        public void Configure(EntityTypeBuilder<DonViSuDung_Module> builder)
        {
            builder.ToTable("DonViSuDung_Modules");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}