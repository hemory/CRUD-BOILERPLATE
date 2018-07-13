using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TheRoundTableApplication.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TheRoundTableApplicationContext(
                serviceProvider.GetRequiredService<DbContextOptions<TheRoundTableApplicationContext>>()))
            {
                if (context.Course.Any()) { }

                {
                    return;
                }

                context.Course.AddRange(
                    new Course
                    {
                        Name = "Ghostbusters ",
                        Description = "The course about ghost"
                    },

                    new Course
                    {
                        Name = "The House Tech ",
                        Description = "The course about huse technology"
                    },

                    new Course
                    {
                        Name = "The room Tech ",
                        Description = "The course about room technology"
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}
