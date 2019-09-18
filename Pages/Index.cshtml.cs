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
        //  string connectionString = "server=localhost;user=root;database=weather;port=3306;password=jg1996";
        // MySqlConnection connection = new MySqlConnection(connectionString);
        // try 
        // {
        //     System.Diagnostics.Debug.WriteLine("Connected");
        //     connection.Open();
        //     string query = "SELECT * FROM precipdata";
        //     MySqlCommand command = new MySqlCommand(query, connection);
        //     MySqlDataReader reader = command.ExecuteReader();

        //     while (reader.Read()) {
        //         Console.WriteLine(reader[1]);
        //     }


        // }
        //  catch (Exception ex)
        // {
        //     Console.WriteLine(ex.ToString());
        // }

        }
    }
}
