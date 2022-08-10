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
    public class VisitprStatisticConfiguration : IEntityTypeConfiguration<VisitorStatistic>
    {
        public void Configure(EntityTypeBuilder<VisitorStatistic> builder)
        {
            builder.ToTable("VisitorStatistics");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
        }
    }
}
