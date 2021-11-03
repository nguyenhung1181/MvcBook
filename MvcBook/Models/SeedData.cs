using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBook.Data;
using System;
using System.Linq;

namespace MvcBook.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBookContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Name = "Sach English",
                        Title = "When Harry Met Sally",
                        Image = "https://salt.tikicdn.com/cache/w1200/ts/product/ea/be/78/bfddd3590adfb3b3901fe77ed7caaa39.jpg",
                        Price = 7.99M
                    },

                    new Book
                    {
                        Name = "Những kẻ xuất chúng",
                        Title = "Ghostbusters ",
                        Image = "https://trinhdinhlinh.com/sach/wp-content/uploads/2017/12/001-000-3.jpg",
                        Price = 8.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
