using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_4.Models.Configurations
{
    internal class Kitap_CFG : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            builder.Property(x => x.Fiyat).HasColumnType("money");
            builder.Property(x => x.KitapAdi).HasColumnType("varchar").HasMaxLength(150).IsRequired();
            builder.Property(x => x.KapakResmi).HasMaxLength(100).HasColumnType("varchar").HasDefaultValue("bos.jpg");

        }
    }
}
