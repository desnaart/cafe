using System;
using MySql.Data.MySqlClient;

namespace UAS_Cafe_Management
{
	public class DatabaseConnection
	{
            private static readonly string connectionString = "server=localhost;user=root;password=mamank546;database=restaurant_dummy;port=8889;";

            // Method to get MySQL connection
            public static MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
	}
}

