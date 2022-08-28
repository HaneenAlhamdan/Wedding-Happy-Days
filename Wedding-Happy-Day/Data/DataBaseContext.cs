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
                            Id = 1 ,
                            Name = "Lujain Beauty Center",
                            Email = "http://www.lujainforwedding.com/",
                            Phone =" 07 8171 4114",
                            Price = 250.91,
                            Address = "",
                            Description = "A specialized department for preparing brides, hairstyles, makeup",
                            Logo = "data:image/jpeg;base64,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",
                           

                        },

                          new Beauty_Center
                          {
                              Id = 2,
                              Name = "Gorgeous Beauty Center",
                              Email = "https://instagram.com/gorgeousbeautycenter?igshid=85yq5nzap8ew",
                              Phone = " 0795681623 ",
                              Price = 400.11,
                              Address = "Sweifyeh - Amman,Jordan",
                              Description = "A specialized department for preparing brides, hairstyles, makeup",
                              Logo = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxIPEBUTEA8QFhAQEBYQEBIPEBAPEhIQFhEWFhYSExYYHTQgGBonHhcYIT0lJSkrLjEuFx83ODUtNygtOi0BCgoKBQUFDgUFDisZExkrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrK//AABEIAOEA4QMBIgACEQEDEQH/xAAcAAEAAgMBAQEAAAAAAAAAAAAABwgEBQYBAwL/xABHEAACAgEBBAUHCAYIBwEAAAAAAQIDEQQFBhIhBxMxQVEiMmFxdIGzCBQjNDVCkaEVYpKxstEkQ1NygpOiozNFUlTB0uEl/8QAFAEBAAAAAAAAAAAAAAAAAAAAAP/EABQRAQAAAAAAAAAAAAAAAAAAAAD/2gAMAwEAAhEDEQA/AJxAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA/E7VFZk0ku1yaSXrbA/YOM290n7L0eYz1asmu2GmTul6sryV72cLtLp7Tlw6TZ85Z7Hfaoyz/AHIJ/wAQE2ggWG/e8ut+raHgi+xw0kkv2rXhn1q0W99/N2yrT7pWaSv8o5aAnUEIQ3W3rf8AzFLHjqv5QPst3N7IebtKuXod0ZfxVgTSCE567e7TedRXcl3qOms/KDUj4Ppj2lpOWv2Sk08N4v03f3cSa/MCcwRVsrpz0FmFfTqaXjzuGN0Pxi+L/SddoukHZdyTjtHTLPYrLFVL3qeGB04NNbvZoIx4pa/SKPi9RVj95yWu6VtJPWafSaKXXz1GprqstSaqrhKaUsN+dLHhy9PcBIwAAAAAAAAAAAAAAAAAAGNtDX1aeuVl1sK64rMp2SUYr1tnJ9IPSHp9kQ4ZYs1Uo5rojJJ47p2P7kfzfdnnium8+9Ws2tcnqLJSzJRqprUuri28KMILtlz7ebYEtb29ONdbcNm1dZLmuvvTjX64Q86XvwcJpdHtreObbndOnPOdsuo0kef3YrlJr0Jvsydp0d9DiSjqNqRbk8ShpOajHvze12v9Ve/PYTRRRGuKjCKjGKxGMUoxSXYkl2ARRu30GaSpKWtunfLvrrbpp/J8T/FEjbH3a0ejWNNpKK/TCuKk/XLtfvZtgB5gYPQAAAHmD8XUxmnGcYyi+TUkpJr0pn0AHDbw9FOzNbl/N1RY/wCs0v0XN97h5r/Ah3fPoi1ugUrKF85ojzcqk1dCP69ff6459xZs84QKQOODoOjx/wD62h9tp+IicOk3otq16nqNHGNesxmUViNeo/vf9M/1u/v8VCm4+nlVtnRwnGUZw19UZxkmpRkrUnFp9jAt2AAAAAAAAAAAAAAAAcV0mb9V7I0/Lhlqrk1p63zXptmk88C9ay+Xjjeb2bfq2bpbNTe/Jrj5MVhSssfm1x9LZUveTbt20NTZqL5N2Wyzj7sIrza4LuilyAxdpa+zU2ztvsc7bZOU7Jdrb7/V6O5LCJ96HOjiOkhHW6uGdVNcVNc19Xg+yWH/AFjX4Ll4nCdCG561+r+cXRzp9G1JJrMbNR2wj6VHzn/hLKJAEj0AAAAAAAAAAAAAAA8aIz383Nj+k9DtGmOJR12nr1aS85O2Ma7XjvTai/Q4+BJp+LK1LtSaynz8U8r88AfsAAAAAAAAAAAAAPGz04/pV3j/AEdsy2yMsXWrqKMPmrJpriXpiuKX+ECFOmjfD5/reprm3pdG5Qjh+TZf2Ts9OPNXoT8SOoLn2Z8F4s8ydH0cbPWp2tpKmsxeojOS8Y15sefRiIFmejvd5bN2dRRjE+DrLvTdPyp/g3w+qKOlPEegAAAAAAAAAAAPHJLtPT46jTQsWJwjJfrRUv3gfTjXij3iXijldt9H+g1UXmmVUu6emtsokn44i+F+9MgvpI3K1mx5KcdRdbpbJcMLeOalGWG+rsWeTwnzXJ4fYBZ7iXihxLxRSj9I3f213+ZP+Y/SN39vb/mT/mBdfiXieca8UV16OOjnVbTgtRqdTqKdI39Hwzl1ty73HLxGPpfb4E1bH3K0OlSVenUmufHfOd88+OZt49wHQpnp+a4KKwkklySSwkvQfoAAAAAAAAAyvvyjNsOero0qfk009dJd3WWSaWfVGC/aLAsqZ0s6rrds6yWey5Vr0KFcYcvwA5Ikv5PulU9ruTSfVaS2xZWcNyrryvdNkaEv/JurzrdVLvWljFeqVqb/AIQLAo9AAAAAAAAAAAAAAABzHSToYXbJ1kZrKWmnYu/E4LjhJepxTOnNDv79l632O74UgKdtn30Gn622uvOOssjDPbjikln8zHM7YX1qj2iv4kQLcbb2vVsvTwbg+qjJUwjFxiopVyklmTSXKDXbzeF3mbsPaa1dELorEbE2lxQnyUmubi2s8u58uw1O/Nlsa6eondGc9TwZogrJcL01+cxcoppYz5yw1F9xn7rwnHTx62VsrHKyUndGNc8ytlLHCpSSSzheU+SQG3AAAAAAAAAABlO9/M/pTWcXb88u/DrHj8sFw2VN6WdL1W2dZHHbcrF6VZXGfL8QORJi+Ta/6Xql3vTwf+5/9IdJT+TvqeHalkM8rNFNe+Ntcv3cQFjgEAAAAAAAAAAAAAAAaHf37L1vsd3wpG+NDv79l632O74UgKdGdsL61R7RV8SJgmdsL61R7RX8SIFp+kqquzSRhbKahO9Jyror1LXDVbNLhkvJzw8PEuaclhrJnbjQrjoq40xca4OyuCdSpzGN0oqfB3cWOLPfnPeN8b4VVQsstsq6u+MoW1xjZ1c3Cccyrf8AxItSlHhSb8pYXLKy92oQWnj1ds7Iyc5uy2LhOdk7JSnJxaWMyb5YSXdyA2oAAAAAAAAAAFfvlGbHcNVRqlF8F1Lom+5WVybWX4uMv9BYE5PpO3b/AEns62mK+mguuo7OdsE2o+9Zj/iAqUdZ0VbR+bbY0k3LClb1Mu5NWxdeH485L3pHKzg12pp+D7j2qbjJSi8Si+KLXamuaYF3Uemo3S2zHX6KjURa+mqjKWOeLEsWR9akmvcbcAAAAAAAAAAAAAAGh39+y9b7Hd8KRvjQ7+/Zet9ju+FICnRnbC+tUe0V/EiYJnbC+tUe0V/EiBbPfGmcoUyrnbGVWpVjdMaJzx1VscJXeR95duez8M3dvU9bp4y62yx5nGU7o1ws442OMoyUEo5TTXLly7zT9I7h81irL6qlK/lO+mu6DcabZuOJ8otqMsSw/DHMytwbIy0NXBKMow46uKE+tjJ12yhKUZYXktxbXLCzhcgOjAAAAAAAAAAAAAVw6cdyno9T88ph/RtVJuzC5Vah836lLt9fF6CLS6e2tl1ayidF8FKq2LjOL5cvFPua7U+5lVd/tzbtk6l1zTlTNt6e7GFZDwfhNd69/YwJF+TzvSk7Nn2S7c36bL7Xj6StfxftE5IpVsraFmlvrupk420zVkGs+cueHjtT7Gu9NltdyN6atq6SF9bxLzLq85lValzi/R3p96aA6EAAAAAAAAAAAAANDv79l632O74UjfGh39+y9b7Hd8KQFOjO2F9ao9or+JEwTO2F9ao9or+JEC2m+lVk6IqrUVUy63i47XwxajVZLhTw+axx9nNQkuxn33Rz80r4roXPymra3xRlF2S4Unjm0sLs7UYPSDCuWlXWxlKPXR8mPzZyb4ZJJK5NPPZhLLz4ZM3dCTlpISk4N2Oyxyr4cS47py4pcKS43nMsLHFkDdgAAAAAAAAAAAABqd49gUbQolRqa1OufulCXdOD+7JG2AFT9/8AcDUbItbadmllL6LUJcuf3LF92f5PuMXcHfG7ZGpVsPKqniN9OcKyHc14SWcp/wDhlstdoq765V3QjOuxcM4TSlGUX3NMgzf7oXsg5XbMzOvtelk/Lj49VJ+ev1Xz9LAmfd3b1G0NPG/TWKVcvdKMu+E192S8DaFQ91t59ZsbUuVXFFp8N+nujKMZpfdsi+afPt7UWF3O6TtDtJRgrVTqGlmi9qLcvCuT5T93P0AduDxM9AAAAAAAAAGh39+y9b7Hd8KRvjm+kfVQq2TrJTkkvmtkFl4zKceCMV6W2l7wKgGdsL61R7RV8SJhMzdhfWqPaK/iRAtnvpNxqraqsnKN3FF1WKqyuUaLmrIN8n2cLXhOXgfTcu2M9JCUIcMZTtcc2q5zTvm+tlNN5lLznz7ZMxekGbjpYyjXKUo3KSnB4dX0Vic+cWuabhzTX0nMzNzYY0dWYuLkpTkmpJuU5uUpPKWW2284SeeSSA3gAAAAAAAAAAAAAAAAYAHPb0bmaLaccaqiMppYjbHyLY+qa5+55RE+2ugW1Szo9ZXKDfm6qLhKK/vQTUvwRPIAiTdndPeLZ+I17Q0llS/qtTO62OPBPh4o+54JI2PbqpR/pdVEJrv0907Yv3ShFr8zZgAAAAAAAAD8Wywm8N4WcLtfoRDfSdoNt7Xapo2fKvRwnxqMtRp+sukuyViU8JLniPPx9UzgCqz6I9sf9l/v6f8A9zJ2X0U7XrvqnLR4jC6E5PrqHiKmm3jiLQADWbc2UtXCMePhlXaroPhjZHjimlxQlyksSfLxw1zSPpsXZq0tMaoyclFyk5NRjmU5ucsJcorLeEuSWEZ4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA//Z",


                          }


                         );

            modelBuilder.Entity<Car_rental>().HasData(
                new Car_rental
                {
                    Id = 1,
                    Name = "Gorgeous Beauty Center",
                    Email = "https://instagram.com/gorgeousbeautycenter?igshid=85yq5nzap8ew",
                    Phone = " 0795681623 ",
                    Price = 400.11,
                    Address = "Sweifyeh - Amman,Jordan",
                    Description = "A specialized department for preparing brides, hairstyles, makeup",
                    Logo =

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