using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using RazorPages.Data;
using RazorPages.Models;

namespace RazorPages.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using(var context = new RazorPagesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesContext>>()))
        {
            if (context == null|| context.Movie==null) 
            {
                throw new ArgumentNullException("Null RazorPagesContext");
            }

            //Look for any movies.
            if (context.Movie.Any())
            {
                return;
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "3/5"
                }, 
                new Movie
                {
                Title = "Амир Топ 1 Взял",
                    ReleaseDate = DateTime.Parse("2023-10-14"),
                    Genre = "Action Triller",
                    Price = 4.3M,
                    Rating = "5/5"
                },
                new Movie
                {
                    Title = "Перевёртыш",
                    ReleaseDate = DateTime.Parse("2023-10-12"),
                    Genre = "Action Triller",
                    Price = 0.1M,
                    Rating = "5/5"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1998-10-12"),
                    Genre = "Action Triller",
                    Price = 80M,
                    Rating = "4/5"
                }
            );

            context.SaveChanges(); 
        }
    }
}
