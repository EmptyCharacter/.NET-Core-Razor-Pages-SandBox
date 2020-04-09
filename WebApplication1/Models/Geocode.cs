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
        
        static private string GetConnectionString()
        {
            return "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog=WebApplication1Context - a3bbc523 - 7d1d - 4287 - b881 - f00b6dd0c988;"
                + "Integrated Security = True;";
        }


        //first create list populated with area names from db
        public static List<string> getFromDataBase()
        {
            
            List<string> list = new List<string>();

            string connectionString = GetConnectionString();
            using(SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                 connection.Open();

                DataTable areas = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(areas);

                foreach (DataRow row in areas.Rows)
                {
                    list.Add(row["Area"].ToString());
                }
            }

            return list;
        }


        //then pass that through method to convert from city name to,
        //lat long format and store that in an array
    }
}
