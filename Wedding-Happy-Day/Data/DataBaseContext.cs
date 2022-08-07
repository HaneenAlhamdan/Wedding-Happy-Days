using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Model;
using Wedding_Happy_Day.Model.Services;

namespace Wedding_Happy_Day.Data
{
    public class DataBaseContext : IdentityDbContext<ApplicationUser>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }


        public DbSet<Beauty_Center> Beauty_Centers { get; set; }
        public DbSet<Car_rental> Car_rentals { get; set; }
        public DbSet<Design_Fashion> Design_Fashions { get; set; }
        public DbSet<Flower_Shop> Flower_Shops { get; set; }
        public DbSet<Food_buffet> Food_buffets { get; set; }
        public DbSet<Hall> Halls { get; set; }


        //Orders related tables
        public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Beauty_Center>().HasData(
                        new Beauty_Center
                        {
                        }



                         );

            modelBuilder.Entity<Car_rental>().HasData(
                new Car_rental
                {
                }

                         );

            modelBuilder.Entity<Design_Fashion>().HasData(
              new Design_Fashion
              {
              }

                       );

            modelBuilder.Entity<Flower_Shop>().HasData(
              new Flower_Shop
              {
              }

                       );

            modelBuilder.Entity<Food_buffet>().HasData(
              new Food_buffet
              {
              }

                       );

            modelBuilder.Entity<Hall>().HasData(
            new Hall
            {
            }

                     );
        }
    }
}