using EF_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Data.Context
{
    internal class PersonelDbContext : DbContext
    {
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<PersonelBolum> PersonelBolumler { get; set; }
        public DbSet<PersonelDetay> PersonelDetaylar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=.; initial catalog=PersonelDb; integrated security=true; trust server certificate=true");
        }



    }
}
