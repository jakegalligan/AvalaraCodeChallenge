using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

public class Server {
    public static void connectServer () {
        string connectionString = "server=localhost;user=root;database=weather;port=3306;password=jg1996";
        MySqlConnection connection = new MySqlConnection(connectionString);
        try 
        {
            System.Diagnostics.Debug.WriteLine("Connected");
            connection.Open();
            string query = "SELECT * FROM precipdata";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            

        }
         catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
}