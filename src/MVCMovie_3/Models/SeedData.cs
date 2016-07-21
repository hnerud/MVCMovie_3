using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCMovie_3.Data;

namespace MVCMovie_3.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }
                context.Movies.AddRange(
                    new Movies
                    {
                        Title = "Star Wars Episode IV",
                        ReleaseDate = DateTime.Parse("1977-5-25"),
                        Genre = "Science Fiction",
                        Price = 10.00M,
                        Rating = "PG"

                    },
                    new Movies
                    {
                        Title = "Princess Bride",
                        ReleaseDate = DateTime.Parse("1987-8-15"),
                        Genre = "Adventure",
                        Price = 5.00M,
                        Rating = "PG"

                    },
                    new Movies
                    {
                        Title = "Top Secret!",
                        ReleaseDate = DateTime.Parse("1984-6-8"),
                        Genre = "Comedy",
                        Price = 3.00M,
                        Rating = "R"

                    }


                    );
                context.SaveChanges();
            }
        }
    }
}
