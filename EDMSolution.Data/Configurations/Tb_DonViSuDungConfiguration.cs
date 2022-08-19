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
    public class Tb_DonViSuDungConfiguration : IEntityTypeConfiguration<Tb_DonViSuDung>
    {
        public void Configure(EntityTypeBuilder<Tb_DonViSuDung> builder)
        {
            builder.ToTable("Tb_DonViSuDungs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
