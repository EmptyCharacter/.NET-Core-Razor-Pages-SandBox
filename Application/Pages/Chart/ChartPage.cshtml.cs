﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Application.Data;

using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using System.Net;

namespace Application
{
    [Serializable]
    public class ChartPageModel : PageModel
    {
        
        private readonly Application.Data.ApplicationContext _context;
        
        public ChartPageModel(ApplicationContext context)
        {
            _context = context;
        }

        
        public EntryInfo EntryInfo { get; set; }
        public List<DateTime> EntryInfoArray { get; set; }
        public List<DateTime> DateList;


        public void OnGet()
        {
            //Retrive all data to be rendered in view
        }


        //-------------------------------First Chart (Bar)-------------------------------------
        
        
    
        public int[] ChartOne()
        {
            //Logic is there but now you need to populate List from the database
            List<DateTime> DateList = _context.EntryInfo.Select(x => x.Date).ToList();
            List<int> temp = SortArray(DateList);
            return temp.ToArray();
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

        //-------------------------------Second Chart (Line)-------------------------------------


        //-------------------------------Third Chart-------------------------------------

        //-------------------------------Fourth Chart (Maps API)-------------------------------------

        public void DoNow()
        {
            //populate list with address data
            List<string> addressList = new List<string>();
            Dictionary<XElement, XElement> LatLngList = new Dictionary<XElement, XElement>();

            foreach(string entry in addressList)
            {
                string requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?key={1}&address={0}&sensor=false", Uri.EscapeDataString(entry), YOUR_API_KEY);

                WebRequest request = WebRequest.Create(requestUri);
                WebResponse response = request.GetResponse();
                XDocument xdoc = XDocument.Load(response.GetResponseStream());

                XElement result = xdoc.Element("GeocodeResponse").Element("result");
                XElement locationElement = result.Element("geometry").Element("location");
                XElement lat = locationElement.Element("lat");
                XElement lng = locationElement.Element("lng");

                //add value to 
                LatLngList.Add(lat, lng);
            }
           

        }

    }
}