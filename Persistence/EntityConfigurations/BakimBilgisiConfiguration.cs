using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations
{
    public class BakimBilgisiConfiguration : IEntityTypeConfiguration<BakimBilgisi>
    {
        public void Configure(EntityTypeBuilder<BakimBilgisi> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Plaka).IsRequired();
            builder.Property(x => x.BakimAciklamasi).IsRequired();
            builder.Property(x => x.GuncelKMBilgisi).IsRequired();
            builder.Property(x => x.OlusturulmaTarihi).HasDefaultValue(DateTime.Now);
            builder.HasOne(x => x.Dorse).WithMany(x => x.BakimBilgileri);
            builder.HasOne(x => x.Tir).WithMany(x => x.BakimBilgileri);
        }
    }
}
