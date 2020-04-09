using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using GoogleMaps.LocationServices;
using Microsoft.Data.SqlClient;

namespace WebApplication1.Models
{
    public class Geocode
    {
        


        //first create list populated with area names from db
        public List<string> getFromDataBase()
        {
            
            List<string> list = new List<string>();

            DataTable areas = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(areas);

            foreach(DataRow row in areas.Rows)
            {
                list.Add(row["Area"].ToString());
            }
            return list;
        }


        //then pass that through method to convert from city name to,
        //lat long format and store that in an array
    }
}
