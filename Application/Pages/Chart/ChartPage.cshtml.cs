﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    public class ChartPageModel : PageModel
    {
        
        private readonly Application.Data.ApplicationContext _context;
        
        public ChartPageModel(Application.Data.ApplicationContext context)
        {
            _context = context;
        }

        public EntryInfo EntryInfo { get; set; }

        public async Task OnGetAsync()
        {
           
        }


        public static void main(string args[])
        {
            sortArray(ChartOne());
        }
        public Array ChartOne()
        {
            int[] MonthCount = new int[12];
            using (var sqlConnection1 = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=ApplicationContext-cbca0afc-a7e0-44c5-bb20-34ae8a99148a;Trusted_Connection=True;MultipleActiveResultSets=true"))
            {
                using (var cmd = new SqlCommand()
                {
                    CommandText = "SELECT * FROM dbo.EntryInfo WHERE id = @id",
                    CommandType = CommandType.Text,
                    Connection = sqlConnection1
                })
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = EntryInfo.Date;
                    sqlConnection1.Open();

                    using(var reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            int counter = 0;
                            for (int i = 1; i <= 12; i++)
                            {
                                //this wont work because im not parsing the date times first
                                if(i.Equals(valueFromReader))
                                {
                                    counter++;
                                }
                                else
                                {
                                    //increment reader
                                }
                                //add value into array
                            }

                        }


                    }
                }
            }

            return MonthCount;
        }


        public Array sortArray(Array test)
        {
            int[] newArray =  new int[12];
            return newArray;
        }


    }
}