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
                        EmployerName = "AeroTek",
                        Position = "Remote Software Developer",
                        City = "San Jose",
                        Date = DateTime.Parse("2020-1-13"),
                        Decision = "Open"
                    },

                    new EntryInfo
                    {
                        EmployerName = "Pack Corp",
                        Position = "Software Developer",
                        City = "San Francisco",
                        Date = DateTime.Parse("2020-4-13"),
                        Decision = "Open"
                    },

                    new EntryInfo
                    {
                        EmployerName = "StollArm",
                        Position = "Software Developer",
                        City = "Phoenix",
                        Date = DateTime.Parse("2020-3-13"),
                        Decision = "Closed"
                    },

                    new EntryInfo
                    {
                        EmployerName = "Randow",
                        Position = "Remote Software Developer",
                        City = "Stockton",
                        Date = DateTime.Parse("2020-4-13"),
                        Decision = "Open"
                    },

                    new EntryInfo
                    {
                        EmployerName = "ClearSol",
                        Position = "Remote Software Developer",
                        City = "Cleaveland",
                        Date = DateTime.Parse("2020-5-13"),
                        Decision = "Remote Software Developer"
                    },

                    new EntryInfo
                    {
                        EmployerName = "ClrSol",
                        Position = "Remote Software Developer",
                        City = "Michigan",
                        Date = DateTime.Parse("2020-6-13"),
                        Decision = "Remote Software Developer"
                    },

                    new EntryInfo
                    {
                        EmployerName = "Tekalt",
                        Position = "Remote Software Developer",
                        City = "California",
                        Date = DateTime.Parse("2020-7-13"),
                        Decision = "Open"
                    },

                    new EntryInfo
                    {
                        EmployerName = "Packers",
                        Position = "Software Developer",
                        City = "Nevada",
                        Date = DateTime.Parse("2020-8-13"),
                        Decision = "Open"
                    },

                    new EntryInfo
                    {
                        EmployerName = "Arm",
                        Position = "Software Developer",
                        City = "Arizona",
                        Date = DateTime.Parse("2020-9-13"),
                        Decision = "Closed"
                    },

                    new EntryInfo
                    {
                        EmployerName = "Randow",
                        Position = "Remote Software Developer",
                        City = "Hawaii",
                        Date = DateTime.Parse("2020-9-13"),
                        Decision = "Open"
                    },

                    new EntryInfo
                    {
                        EmployerName = "Shulker",
                        Position = "Remote Software Developer",
                        City = "Wyoming",
                        Date = DateTime.Parse("2020-11-13"),
                        Decision = "Remote Software Developer"
                    },

                    new EntryInfo
                    {
                        EmployerName = "Abjol",
                        Position = "Remote Software Developer",
                        City = "Ohio",
                        Date = DateTime.Parse("2020-12-13"),
                        Decision = "Remote Software Developer"
                    }

                );
                context.SaveChanges();
            }
        }




    }
}
