using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LabWorks
{
    internal class DataAccessLayer
    {
        // ЛР №45
        public static string ServerName { get; set; } = @"prserver\SQLEXPRESS";
        public static string DatabaseName { get; set; } = "ispp2113";
        public static string Login { get; set; } = "ispp2113";
        public static string Password { get; set; } = "2113";
        public static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new()
                {
                    DataSource = ServerName,
                    UserID = Login,
                    Password = Password,
                    InitialCatalog = DatabaseName,
                    TrustServerCertificate = true
                };
                return builder.ConnectionString;
            }
        }

        public static object GetValue(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);

            return command.ExecuteScalar();
        }

        public static DataTable GetTable(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);
            using SqlDataAdapter adapter = new(query, connection);

            DataTable table = new();
            adapter.Fill(table);
            return table;
        }

        public static List<Book> GetBooks(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);
            List<Book> books = new();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var book = new Book
                {
                    Id = (int)reader["BookId"],
                    Title = reader["Title"].ToString(),
                    Price = Convert.ToDouble(reader["Price"])
                };
                books.Add(book);
            }
            return books;
        }

        // ЛР №46
        public static int GetAffectedRows(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);
            return Convert.ToInt32(command.ExecuteNonQuery());
        }

        public static bool UpdateBookById(int bookId, decimal price)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = $"UPDATE Book SET Price = {price} WHERE BookId = {bookId}";

            SqlCommand command = new(query, connection);
            return command.ExecuteNonQuery() > 0;
        }

        public static DataTable GetTableByName(string name)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = $"SELECT * FROM {name}";
            SqlCommand command = new(query, connection);
            using SqlDataAdapter adapter = new(query, connection);

            DataTable table = new();
            adapter.Fill(table);
            return table;
        }

        public static void UpdateTableByName(ref DataTable table, string name) // доделать (Задание 4 ЛР №46)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = $"UPDATE * SET ";
            SqlCommand command = new(query, connection);

            using SqlDataAdapter adapter = new(query, connection);
            SqlCommandBuilder builder = new(adapter);
            adapter.Update(table); // sending changes to DB

            table.Clear();
            adapter.Fill(table);
        }

        // ЛР №47
        public static int GetBooksCountByPrice(decimal price) // Задание 1
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "SELECT COUNT(*) FROM Book WHERE Price < @price";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@price", price);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public static int GetId(string query) // Задание 2
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            query += "; SET @id = SCOPE_IDENTITY()";
            SqlCommand command = new(query, connection);
            SqlParameter id = new("@id", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;
            command.Parameters.Add(id);
            command.ExecuteNonQuery();

            return Convert.ToInt32(id.Value);
        }

        public static DataTable GetBooksByPriceAndGenre(decimal price, string genre)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "SELECT * FROM Book WHERE Price < @price AND Genre = @genre";
            SqlDataAdapter adapter = new(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@price", price);
            adapter.SelectCommand.Parameters.AddWithValue("@genre", genre);

            DataTable table = new();
            adapter.Fill(table);
            return table;
        }

        public static bool ChangeBook(int bookId, decimal price, string title)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "UPDATE Book SET Price = @price, Title = @title WHERE BookId = @bookId";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@bookId", bookId);
            return command.ExecuteNonQuery() > 0;
        }

        //ЛР №48

        public static void AddAuthor(string surname, string name, string country)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "AddAuthor";
            SqlCommand command = new(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@country", country);
            command.ExecuteNonQuery();
        }

        public static int GetAuthorId(string surname, string name, string country)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "GetAuthorId";
            SqlCommand command = new(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@country", country);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public static DataTable GetBooks(decimal startPrice, decimal endPrice)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "GetBooks";

            DataTable table = new();
            using SqlDataAdapter adapter = new(query, connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@endPrice", endPrice);
            adapter.SelectCommand.Parameters.AddWithValue("@startPrice", startPrice);
            adapter.Fill(table);

            return table;
        }
    }
}
