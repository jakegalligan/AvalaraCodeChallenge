using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Web.Script.Serialization;

namespace AvalaraCodeChallenge.Pages
{
    public class IndexModel : PageModel
    {
        public void OnPost()
        {
        //when the date form is submitted store the input data into a variable
        var date;

        //if the user entered a date assign that value to the data variable
        if ( Request.Form["date"] != null) {
            date = Request.Form["date"];
        } else {
            //otherwise make the date the current day
            DateTime thisDay = DateTime.Today;
            date =thisDay.ToString("d");

        }
        Console.WriteLine(date);
        //create a connection to the mysql database on the local host
         string connectionString = "server=localhost;user=root;database=weather;port=3306;password=jg1996";
         MySqlConnection connection = new MySqlConnection(connectionString);
        
        try 
        {
            //if the connection succeds create a connection to the database
            connection.Open();
            //create a database query and retrieve the desired data from server
            string query = ($"SELECT precip FROM precipdata WHERE date='{date}'");
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            //initiliaze a list to store the data given back from the query
            List <double> precipitationAmounts = new List <double>();
            //read the data sent back from query
            while (reader.Read()) {
            //for each data point returned from query add value to list
            precipitationAmounts.Add(Convert.ToDouble(reader[0]));
            }
            //get the average precipitation for the given date
            double predictedPrecip = this.getAverage(precipitationAmounts);
            //create a new object with the predicted precipitation
            var obj = ObjectToStoreData(predictedPrecip);
            //convert the object into json
            var jsonObject = new JavaScriptSerializer().Serialize(obj);



        }
         catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        }
        public double getAverage(List<double> list )
        {
            //get the sum and count of all values in the list and calculate the mean
            double sum = list.Sum();
            Console.WriteLine("sum", sum);
            double count = list.Count;
            Console.WriteLine("coutn", count);
            double mean = sum/count;
            Console.WriteLine("the mean is", mean);
            return mean;
        }
        class ObjectToStoreData {
            double Predictedprecipitation;
            ObjectToStoreData(double predictedprecipitation) {
                Predictedprecipitation = predictedprecipitation;
            }
        }
        
    }
}
