using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    internal class AlbumBilgisiMapping : IEntityTypeConfiguration<AlbumBilgisi>
    {
        public void Configure(EntityTypeBuilder<AlbumBilgisi> builder)
        {
            builder.ToTable("AlbümBilgileri");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .HasColumnName("AlbumId")
                   .HasColumnOrder(1);

            builder.Property(x => x.AlbumAdi)
                   .HasColumnName("AlbümAdı")
                   .HasColumnType("nvarchar(max)")
                   .HasColumnOrder(2)
                   .IsRequired();

            builder.Property(x => x.SanatciveyaGrup)
                   .HasColumnName("SanatçıveyaGrup")
                   .HasColumnType("nvarchar(max)")
                   .HasColumnOrder(3)
                   .IsRequired();

            builder.Property(x => x.CikisTarihi)
                   .HasColumnName("ÇıkışTarihi")
                   .HasColumnType("date")
                   .HasColumnOrder(4)
                   .IsRequired();

            builder.Property(x => x.Fiyat)
                   .HasColumnType("int")
                   .HasColumnType("decimal(7,2)")
                   .HasColumnOrder(5)
                   .IsRequired();

            builder.Property(x => x.IndirimOrani)
                   .HasColumnName("İndirimOranı")
                   .HasColumnType("int")
                   .HasColumnOrder(6)
                   .IsRequired();

            builder.Property(x => x.SatisiVarMi)
                   .HasColumnName("SatisiVarMi")
                   .HasColumnType("bit")
                   .HasColumnOrder(7)
                   .IsRequired();

            builder.Property(x => x.CreatedDate)
                   .HasColumnType("datetime2")
                   .HasColumnOrder(8)
                   .IsRequired();
        }
    }
}
