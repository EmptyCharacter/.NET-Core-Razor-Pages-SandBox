using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Application.Models;
using Application.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    
    public class ChartPageModel : PageModel
    {
        
        private readonly Application.Data.ApplicationContext _context;
        
        public ChartPageModel(ApplicationContext context)
        {
            _context = context;
        }

        
        
        public List<DateTime> DateList;


        public void OnGet()
        {
            //Retrive all data to be rendered in view
        }


        //-------------------------------First Chart (Bar)-------------------------------------

        
        
        

        public List<EntryInfo> GetDataList(ApplicationContext _context)
        {
            var entryItems = _context.EntryInfo
            .Include(b => b.City)
            .ToList();
            return entryItems;
        }

        public List<int> ChartOne()
        {
            List<EntryInfo> entries = GetDataList(_context);
            List<DateTime> DateList = entries.Select(x => x.Date).ToList();
            List<int> temp = SortArray(DateList);
            return temp;
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

        public void SecondNow()
        {
            List<Point> pointList = new List<Point>();
        }

        //-------------------------------Third Chart-------------------------------------

        //-------------------------------Fourth Chart (Maps API)-------------------------------------

            /*
        public Dictionary<XElement, XElement> DoNow()
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

            return LatLngList;

        }*/

    }
}