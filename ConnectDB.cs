using System;
using MySql.Data.MySqlClient;

class ConnectDB
{
    public void AddMenu(string menuName, string capital, string price, string menuImg, string info, int groupId)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO menu (menu_name, capital, price, menu_img, info, group_id) " +
                               "VALUES (@MenuName, @Capital, @Price, @MenuImg, @Info, @GroupId);";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Parameterisasi untuk mencegah SQL Injection
                command.Parameters.AddWithValue("@MenuName", menuName);
                command.Parameters.AddWithValue("@Capital", capital);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@MenuImg", menuImg);
                command.Parameters.AddWithValue("@Info", info);
                command.Parameters.AddWithValue("@GroupId", groupId);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Data menu berhasil ditambahkan!");
                }
                else
                {
                    Console.WriteLine("Gagal menambahkan data menu.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }