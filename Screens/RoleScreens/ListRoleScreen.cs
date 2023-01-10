using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudo_Dapper.Models;
using Estudo_Dapper.Repositories;

namespace Estudo_Dapper.Screens.RoleScreens
{
    public static class ListRoleScreen
    {
        
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Roles");
            Console.WriteLine("-------------");

            List();

            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();

            foreach(var role in roles)
            {
                Console.WriteLine($"{role.Name}");
            }
        }
    }
}