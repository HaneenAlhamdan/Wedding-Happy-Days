using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Model;

namespace Wedding_Happy_Day.Data
{
    public class DataBaseContext
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
        }
    }
}