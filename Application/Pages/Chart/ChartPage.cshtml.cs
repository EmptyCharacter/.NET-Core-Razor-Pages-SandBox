﻿using System;
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
        List<String> CityList;

        public string barChart { get; set; }
        public List<Google.Type.LatLng> locations { get; set; }


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
        
        public void OnGet()
        {
            PopulateCollections();

            barChart = Serialize(SortArray(DateList));
            locations = LatLngConvert(CityList);
        }

        //-------------------------------First Chart (Bar)-------------------------------------

        public int[] SortArray(List<DateTime> test)
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
            return tempList.ToArray();
        }

        public string Serialize(int[] vs)
        {
            var temp = JsonConvert.SerializeObject(vs);
            return temp;
        }

        //-------------------------------Second Chart (Line)-------------------------------------

        

        //-------------------------------Third Chart-------------------------------------

        //-------------------------------Fourth Chart (Maps API)-------------------------------------

        public List<Google.Type.LatLng> LatLngConvert(List<String> cityList)
        {

            List<Google.Type.LatLng> temp;
            foreach(String s in cityList)
            {
                
                string requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?key={1}&address={0}&sensor=false", Uri.EscapeDataString(s), "AIzaSyAuu_QlTSLJQaNXShxwuHtN3vEa4frY2Sg");

                WebRequest request = WebRequest.Create(requestUri);
                WebResponse response = request.GetResponse();
                XDocument xdoc = XDocument.Load(response.GetResponseStream());

                XElement result = xdoc.Element("GeocodeResponse").Element("result");
                XElement locationElement = result.Element("geometry").Element("location");
                XElement lat = locationElement.Element("lat");
                XElement lng = locationElement.Element("lng");
                Google.Type.LatLng spme = new Google.Type.LatLng(lat, lng);
            }
               
            

            return temp;
        }
        

    }
}