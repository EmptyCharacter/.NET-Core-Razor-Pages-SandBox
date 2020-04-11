using Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new ApplicationContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationContext>>()))
            {
                if(context.EntryInfo.Any())
                {
                    return;
                }

                context.EntryInfo.AddRange(
                    new EntryInfo
                    {
                        EmployerName = "",
                        Position = "",
                        City = "",
                        Date = DateTime.Parse("2020-4-13"),
                        Decision = ""
                    },

                    new EntryInfo
                    {
                        EmployerName = "",
                        Position = "",
                        City = "",
                        Date = DateTime.Parse("2020-4-13"),
                        Decision = ""
                    },

                    new EntryInfo
                    {
                        EmployerName = "",
                        Position = "",
                        City = "",
                        Date = DateTime.Parse("2020-4-13"),
                        Decision = ""
                    },

                    new EntryInfo
                    {
                        EmployerName = "",
                        Position = "",
                        City = "",
                        Date = DateTime.Parse("2020-4-13"),
                        Decision = ""
                    },

                    new EntryInfo
                    {
                        EmployerName = "",
                        Position = "",
                        City = "",
                        Date = DateTime.Parse("2020-4-13"),
                        Decision = ""
                    }
                );
                context.SaveChanges();
            }
        }




    }
}
