using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Estudo_Dapper.Models;
using Estudo_Dapper.Repositories;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User Id=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";

ReadUsers(OpenConnection());
ReadRoles(OpenConnection());
ReadTags(OpenConnection());
//ReadUser();
//CreateUser();
//UpdateUser();
//DeleteUser();


SqlConnection OpenConnection()
{
    var connection = new SqlConnection(CONNECTION_STRING);
    return connection;
}

void ReadUsers(SqlConnection connection)
{
    connection = OpenConnection();

    var repository = new Repository<User>(connection);
    var items = repository.Get();
    
    foreach(var item in items)
    {
        Console.WriteLine(item.Name);
    }

    connection.Close();
}

void ReadRoles(SqlConnection connection)
{
    connection = OpenConnection();

    var repository = new Repository<Role>(connection);
    var items = repository.Get();
    
    foreach(var item in items)
    {
        Console.WriteLine(item.Name);
    }

    connection.Close();
}

void ReadTags(SqlConnection connection)
{
    connection = OpenConnection();

    var repository = new Repository<Tag>(connection);
    var items = repository.Get();
    
    foreach(var item in items)
    {
        Console.WriteLine(item.Name);
    }

    connection.Close();
}
