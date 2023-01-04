using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Blog.Models;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User Id=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";

ReadUsers();
//ReadUser();
//CreateUser();
//UpdateUser();
//DeleteUser();

void ReadUsers()
{
    using(var connection = new SqlConnection(CONNECTION_STRING))
    {
        var users = connection.GetAll<User>();

        foreach(var user in users)
        {
            Console.WriteLine(user.Name);
        }
    }
}

void ReadUser()
{
    using(var connection = new SqlConnection(CONNECTION_STRING))
    {
        var user = connection.Get<User>(1);
        Console.WriteLine(user.Name);
    }
}

void CreateUser()
{
    var user = new User()
    {
        Bio = "Equipe Balta.io",
        Email = "hello@balta.io",
        Image = "https://",
        Name = "Equipe Balta.io",
        PasswordHash = "HASH",
        Slug = "equipe-balta"
    };

    using(var connection = new SqlConnection(CONNECTION_STRING))
    {
        connection.Insert<User>(user);
        Console.WriteLine("Cadastro realizado com sucesso!");
    }
}

void UpdateUser()
{
    var user = new User()
    {
        Id = 2,
        Bio = "Equipe | Balta.io",
        Email = "hello@balta.io",
        Image = "https://",
        Name = "Equipe de suporte Balta.io",
        PasswordHash = "HASH",
        Slug = "equipe-balta"
    };

    using(var connection = new SqlConnection(CONNECTION_STRING))
    {
        connection.Update<User>(user);
        Console.WriteLine("Cadastro atualizado com sucesso!");
    }
}

void DeleteUser()
{
    using(var connection = new SqlConnection(CONNECTION_STRING))
    {
        var user = connection.Get<User>(2);
        connection.Delete<User>(user);
        Console.WriteLine("Cadastro excluído com sucesso!");
    }
}