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
    internal class TirConfiguration : IEntityTypeConfiguration<Tir>
    {
        public void Configure(EntityTypeBuilder<Tir> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OlusturulmaTarihi).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Plaka).IsRequired().HasMaxLength(8);
            builder.HasAlternateKey(x => x.Plaka);

            builder.HasOne(x => x.Kullanici).WithOne(x => x.Tir).HasForeignKey<Kullanici>(x=>x.TirId);

        }
    }
}
