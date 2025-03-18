
using EF_1.Models;
using Microsoft.Data.SqlClient;

string connStr = "Data source=.; initial catalog=Northwind; integrated security=true; trust server certificate=true";

SqlConnection connection = new SqlConnection(connStr);

InsertCategory(new Category { CategoryName = "Şekerlemeler" });

connection.Open();

SqlCommand cmd = new SqlCommand("select * from categories", connection);

SqlDataReader reader = cmd.ExecuteReader();

List<Category> categories = new List<Category>();

while (reader.Read())
{
    Console.WriteLine(reader[0] + " " + reader[1]); // categoryname kolonu -> 1
    Category category = new Category()
    {
        CategoryID = reader.GetInt32(0),
        CategoryName = reader.GetString(1)

    };

    categories.Add(category);
}

connection.Close();

void InsertCategory(Category category)
{
    connection.Open();
    SqlCommand command = new SqlCommand("insert into categories (CategoryName) values(@name)", connection);

    command.Parameters.Clear();
    command.Parameters.AddWithValue("@name", category.CategoryName);

    command.ExecuteNonQuery();

    connection.Close();
}

Console.WriteLine();