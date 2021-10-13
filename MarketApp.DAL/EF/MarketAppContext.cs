using MarketApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.DAL.EF
{
    class MarketAppContext : DbContext
    {
        public MarketAppContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MarketAppDb;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>().HasData(
                new Shop[]
                {
                    new Shop{Id=1,Name="22vek",Address="ул. Пушкина, 40", Shedule="10:00-20:00 Выходные: Сб, Вс"},
                    new Shop{Id=2,Name="Магазин электроники",Address="ул. Гоголя, 88", Shedule="09:00-18:00 Выходные: Вс"},
                    new Shop{Id=3,Name="ЧипИДейл",Address="МКАД, 22 км", Shedule="08:00-20:00 Без выходных"}
                });
            modelBuilder.Entity<Product>().HasData(
                 new Product[]
                 {
                    new Product{Id=1,Name="Стиральная машина Samsung",Description="Суперновая стиральная машина с хорошими функциями",ShopId=1},
                    new Product{Id=2,Name="Холодильник Indesit",Description="Двухкамерный холодильник серого цвета",ShopId=1},
                    new Product{Id=3,Name="Беспроводные наушники Marshall",Description="Супер-наушники с длительным временем работы и высокой мощностью звука",ShopId=2},
                    new Product{Id=4,Name="Безпроводная мышь",Description="Bluetooth-мышь",ShopId=2},
                    new Product{Id=5,Name="Стеклоомывающая жидкость",Description="Жидкость -20 С синего цвета",ShopId=3},
                    new Product{Id=6,Name="Щётки теклоочистителей Bosch",Description="Безкаркасные щётки, 600 мм",ShopId=3},
                 });
        }
    }
}
