using EF_4.Models;
using EF_4.Models.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_4.Context
{
    internal class KirtasiyeDbContext : DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<KitapYazar> KitapYazarlar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kod> Kodlar { get; set; }
        public DbSet<Yayinevi> Yayinevleri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=.; initial catalog=KirtasiyeDb; integrated security=true; trust server certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Yazar>().Property(x => x.YazarAdi).HasColumnType("varchar").HasMaxLength(25);

            // cfg sınıflarını kullanmak
            // 1. yöntem
            // modelBuilder.ApplyConfiguration(new Kitap_CFG());
            // 2. yöntem
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
