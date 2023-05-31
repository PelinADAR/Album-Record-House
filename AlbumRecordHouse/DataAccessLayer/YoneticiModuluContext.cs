using DataAccessLayer.Mapping;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class YoneticiModuluContext : DbContext
    {
        public DbSet<YoneticiGirisBilgisi> YoneticiGirisBilgileri { get; set; }
        public DbSet<AlbumBilgisi> AlbumBilgileri { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-A10URF2\\SQLEXPRESS;Database=YoneticiGiris;Encrypt=false;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new YoneticiGirisBilgisiMapping());
            modelBuilder.ApplyConfiguration(new AlbumBilgisiMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
