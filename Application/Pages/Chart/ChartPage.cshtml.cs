using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Application.Models;
using Application.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataLibrary.DataAccess;
using Newtonsoft.Json;
using System.Net;
using System.Xml.Linq;
using System.Collections;


namespace Application
{
    
    public class ChartPageModel : PageModel
    {
        
        private readonly Application.Data.ApplicationContext _context;

        private List<DateTime> DateList;
        private List<String> CityList;

        public string barChart { get; set; }
        public string locations { get; set; }


        public ChartPageModel(ApplicationContext context)
        {
            _context = context;
        }
        


        //-------------------------------Data Retrival-------------------------------------


        public static List<EntryInfo> LoadEntryInfo()
        {
            string sql = @"select Id, EmployerName, Position, City, Date, Decision
                            from dbo.EntryInfo";
            return SqlDataAccess.LoadData<EntryInfo>(sql);
        }

        public void PopulateCollections()
        {
            //Load data from model
            List<EntryInfo> entries = LoadEntryInfo();
            DateList = entries.Select(x => x.Date).ToList();
            CityList = entries.Select(x => x.City).ToList();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IGeocoder geocoder = new GoogleGeocoder() { };
            Address[] addresses = geocoder.Geocode("#65/1 bangalore").ToArray();
            foreach (Address adrs in addresses)
            {
                Response.Write("address:" + adrs.Coordinates);
            }
        }

        public void OnGet()
        {
            PopulateCollections();

            barChart = JsonConvert.SerializeObject(SortDates(DateList));
            
        }

        //-------------------------------First Chart (Bar)-------------------------------------

        public List<int> SortDates(List<DateTime> test)
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

        

        //-------------------------------Second Chart (Line)-------------------------------------

        

        //-------------------------------Third Chart-------------------------------------

        //-------------------------------Fourth Chart (Maps API)-------------------------------------
        

        

        
        

    }
}