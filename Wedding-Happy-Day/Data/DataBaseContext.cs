using Microsoft.AspNetCore.Identity;
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

            // any unique string id
            const string ADMIN_ID = "a18be9c0";
            const string ADMIN_ROLE_ID = "ad376a8f";

            // create an Admin role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ADMIN_ROLE_ID,
                Name = "Administrator",
                NormalizedName = "Administrator"
            });

            // create a User
            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "Administrator",
                NormalizedUserName = "Administrator",
                Email = "Administrator@gmail.com",
                NormalizedEmail = "Administrator@gmail.com",
                EmailConfirmed = false,
                PasswordHash = hasher.HashPassword(null, "Admin123#"),
                SecurityStamp = string.Empty
            });

            // assign that user to the admin role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_ID
            });

        }
    }
}