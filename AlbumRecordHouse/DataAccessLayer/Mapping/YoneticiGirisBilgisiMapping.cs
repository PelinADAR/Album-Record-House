using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Mapping
{
    internal class YoneticiGirisBilgisiMapping : IEntityTypeConfiguration<YoneticiGirisBilgisi>
    {
        public void Configure(EntityTypeBuilder<YoneticiGirisBilgisi> builder)
        {
            builder.ToTable("Yöneticiler");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .HasColumnName("YöneticiId")
                   .HasColumnOrder(1)
                   .IsRequired();

            builder.HasIndex(x=>x.KullaniciAdi)
                    .IsUnique();

            builder.Property(x => x.KullaniciAdi)
                   .HasColumnName("KullanıcıAdı")
                   .HasColumnType("nvarchar(64)")
                   .HasColumnOrder(2)
                   .IsRequired();

            builder.Property(x => x.Sifre)
                   .HasColumnName("Şifre")
                   .HasColumnType("nvarchar(64)")
                   .HasColumnOrder(3)
                   .IsRequired();

            builder.Property(x => x.CreatedDate)
                   .HasColumnType("datetime2")
                   .HasColumnOrder(4)
                   .IsRequired();
        }
    }
}
