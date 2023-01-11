using Microsoft.Data.SqlClient;
using Estudo_Dapper.Screens.TagScreens;
using Estudo_Dapper;
using Estudo_Dapper.Screens.UserScreens;
using Estudo_Dapper.Screens.RoleScreens;
using Estudo_Dapper.Screens.Relatorios;
using Estudo_Dapper.Screens.CateogryScreens;
using Estudo_Dapper.Screens.PostScreens;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User Id=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";

Database.Connection = new SqlConnection(CONNECTION_STRING);
Database.Connection.Open();

Load();

Console.ReadKey();
Database.Connection.Close();


static void Load()
{
    Console.Clear();
    Console.WriteLine("Meu Blog");
    Console.WriteLine("---------------");
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine();
    Console.WriteLine("1 - Gestão de usuário");
    Console.WriteLine("2 - Gestão de perfil");
    Console.WriteLine("3 - Gestão de categoria");
    Console.WriteLine("4 - Gestão de Post");
    Console.WriteLine("5 - Gestão de Tag");
    Console.WriteLine("6 - Vincular Perfil/Usuario");
    Console.WriteLine("7 - Relatórios");
    Console.WriteLine();
    Console.WriteLine();

    var option = short.Parse(Console.ReadLine());

    switch(option)
    {
        case 1:
            MenuUserScreen.Load();
            break;
        case 2:
            MenuRoleScreen.Load();
            break;
        case 3:
            MenuCategoryScreen.Load();
            break;
        case 4:
            MenuPostScreen.Load();
            break;
        case 5:
            MenuTagScreen.Load();
            break;
        case 6:
            AddUserRoleScreen.Load();
            break;
        case 7:
            MenuRelatoriosScreen.Load();
            break;
        default:
            Load();
            break;
    }
}
