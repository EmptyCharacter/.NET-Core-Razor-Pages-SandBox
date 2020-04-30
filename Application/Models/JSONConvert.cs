using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Application.Models
{
  
    public List<EntryInfo> getData()
    {
        var con = ConfigurationManager.ConnectionStrings["ApplicationContext-cbca0afc-a7e0-44c5-bb20-34ae8a99148a"].ToString();

        List<EntryInfo> matchingInfo = new List<EntryInfo>();
        using(SqlConnection myConnection = new SqlConnection(con))
        {
            string oString = "Select * from EntryInfo where ";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            oCmd.Parameters.AddWithValue();
            myConnection.Open();
            using(SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while(oReader.Read())
                {
                   //retrive info here
                }
                myConnection.Close();
            }
        }
        return matchingInfo;
    }





}
