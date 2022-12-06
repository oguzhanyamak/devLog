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
    public class DorseEntityConfiguration : IEntityTypeConfiguration<Dorse>
    {
        public void Configure(EntityTypeBuilder<Dorse> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Plaka).IsRequired();
            builder.HasAlternateKey(x => x.Plaka);
            builder.Property(x => x.OlusturulmaTarihi).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Durum).HasDefaultValue(true);
        }
    }
}
