using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Application.Models;
using Application.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataLibrary.DataAccess;
using Newtonsoft.Json;

namespace Application
{
    
    public class ChartPageModel : PageModel
    {
        
        private readonly Application.Data.ApplicationContext _context;

        public string barChart { get; set; }
        public string lineChart { get; set; }

        public ChartPageModel(ApplicationContext context)
        {
            _context = context;
        }
        //CHECK TO SEE IF CHART WILL RENDER WITHOUT SERIALIZATION



        //-------------------------------Data Retrival-------------------------------------


        public static List<EntryInfo> LoadEntryInfo()
        {
            string sql = @"select Id, EmployerName, Position, City, Date, Decision
                            from dbo.EntryInfo";
            return SqlDataAccess.LoadData<EntryInfo>(sql);
        }

        //-------------------------------First Chart (Bar)-------------------------------------

        public void OnGet()
        {
            barChart = ChartOne();
        }

        public string ChartOne()
        {
            List<EntryInfo> entries = LoadEntryInfo();
            List<DateTime> DateList = entries.Select(x => x.Date).ToList();
            List<int> temp = SortArray(DateList);
            int[] ints = temp.ToArray();
            var serializedObject = Serialize(ints);
            return serializedObject;
        }

        public List<int> SortArray(List<DateTime> test)
        {
            List<int> tempList = new List<int>();
            for (var i = 1; i <= 12; i++)
            {
                int counter = 0;
                foreach (DateTime d in test)
                {
                    if (d.Month == i)
                    {
                        counter++;

                    }
                }
                tempList.Add(counter);

            }
            return tempList;
        }

        public string Serialize(int[] vs)
        {
            var temp = JsonConvert.SerializeObject(vs);
            return temp;
        }

        //-------------------------------Second Chart (Line)-------------------------------------

        

        //-------------------------------Third Chart-------------------------------------

        //-------------------------------Fourth Chart (Maps API)-------------------------------------

        public void LatLngConvert()
        {

        }
        

    }
}