using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjeDeneme_MVC_Efcore_CodeFirst.Models
{
    public class MyDbContext :DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<City> City { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Deneme.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product(){Id=1, Name="Ipone 13"},
                    new Product(){Id=2, Name="Dell Xside"},
                    new Product(){Id=3, Name="Samsung A71"},
                    new Product(){Id=4, Name="Piranha X13" }
                );
            
            modelBuilder.Entity<City>()
                .HasData(
                    new City(){Id=1, Name="Rize"},
                    new City(){Id=2, Name="Kars"},
                    new City(){Id=3, Name="Samsun"},
                    new City(){Id=4, Name="İstanbul"},
                    new City(){Id=5, Name="Ankara"}
                );
        }
    }
}