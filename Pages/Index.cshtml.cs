using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AvalaraCodeChallenge.Pages
{
    public class IndexModel : PageModel
    {
        public void OnPost()
        {
        //when the date form is submitted store the input data into a variable
        var date = Request.Form["date"];
        //create a connection to the mysql database on the local host
         string connectionString = "server=localhost;user=root;database=weather;port=3306;password=jg1996";
         MySqlConnection connection = new MySqlConnection(connectionString);
        
        try 
        {
            //if the connection succeds create a connection to the database
            connection.Open();
            //create a database query and retrieve the desired data from server
            string query = "SELECT * FROM precipdata";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            //initiliaze a list to store the data given back from the query
            List <double> precipitationAmounts = new List <double>();
            //read the data sent back from query
            while (reader.Read()) {
            //for each data point returned from query add value to list
            precipitationAmounts.Add(Convert.ToDouble(reader[6]));
            }


            
            Console.WriteLine("the average is", this.getAverage(precipitationAmounts));


        }
         catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        }
        public double getAverage(List<double> list )
        {
            //get the sum of all the values in the list
            double sum = list.Sum();
            Console.WriteLine("sum", sum);
            double count = list.Count;
            Console.WriteLine("coutn", count);
            double mean = sum/count;
            Console.WriteLine("the mean is", mean);
            return mean;
        }
        
    }
}
