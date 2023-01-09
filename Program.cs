using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Estudo_Dapper.Models;
using Estudo_Dapper.Repositories;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User Id=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";

//CreateUsers(OpenConnection());
ReadUsers(OpenConnection());
//ReadRoles(OpenConnection());
//ReadTags(OpenConnection());


SqlConnection OpenConnection()
{
    var connection = new SqlConnection(CONNECTION_STRING);
    return connection;
}

void ReadUsers(SqlConnection connection)
{
    connection = OpenConnection();

    var userRepository = new UserRepository(connection);
    var items = userRepository.GetWithRoles();
    
    foreach(var item in items)
    {
        Console.WriteLine(item.Name);
        foreach(var role in item.Roles)
        {
            Console.WriteLine($" - {role.Name}");
        }
    }

    connection.Close();
}

void CreateUsers(SqlConnection connection)
{
    connection = OpenConnection();

    var user = new User()
    {
        Email = "email@balta.io",
        Bio = "bio",
        Image = "imagem",
        Name = "Name",
        PasswordHash = "hash",
        Slug = "slug"
    };

    var repository = new Repository<User>(connection);
    repository.Create(user);
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
