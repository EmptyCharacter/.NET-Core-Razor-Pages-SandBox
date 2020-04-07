using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Data;
using System;
using System.Linq;

namespace WebApplication1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebApplication1Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebApplication1Context>>()))
            {
                //Look for instance
                if(context.AppTracker.Any())
                {
                    return; //DB has been seeded
                }

                context.AppTracker.AddRange(
                    new AppTracker
                    {
                        DateSent = DateTime.Parse("2020-4-1"),
                        EmployerName = "Cisco",
                        Position = "Remote Software Developer",
                        Area = "California",
                        AppStatus = "No Response"
                    },

                    new AppTracker
                    {
                        DateSent = DateTime.Parse("2020-4-1"),
                        EmployerName = "TekSystems",
                        Position = "Remote Software Developer",
                        Area = "Michigan",
                        AppStatus = "No Response"
                    },

                    new AppTracker
                    {
                        DateSent = DateTime.Parse("2020-3-15"),
                        EmployerName = "Aerotyne",
                        Position = "Remote Software Developer",
                        Area = "Utah",
                        AppStatus = "No Response"
                    },
                    new AppTracker
                    {
                        DateSent = DateTime.Parse("2020-4-2"),
                        EmployerName = "Fish and Base",
                        Position = "Remote Software Developer",
                        Area = "Hawaii",
                        AppStatus = "No Response"
                    },
                    new AppTracker
                    {
                        DateSent = DateTime.Parse("2020-4-1"),
                        EmployerName = "Alexin Company",
                        Position = "Software Developer",
                        Area = "Hawaiii",
                        AppStatus = "No Response"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
