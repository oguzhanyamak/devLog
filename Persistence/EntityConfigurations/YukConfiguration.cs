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
    public class YukConfiguration : IEntityTypeConfiguration<Yuk>
    {
        public void Configure(EntityTypeBuilder<Yuk> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Durum).HasDefaultValue(true);
            builder.Property(x => x.OlusturulmaTarihi).HasDefaultValue(DateTime.Now);
            builder.HasOne(x => x.Tir).WithMany(x => x.Yukler);
            builder.HasOne(x => x.Dorse).WithMany(x => x.Yukler);
        }
    }
}
