using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudo_Dapper.Repositories;

namespace Estudo_Dapper.Screens.Relatorios
{
    public static class ListUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Usuários e Roles");
            Console.WriteLine("-------------");

            List();

            Console.ReadKey();
            MenuRelatoriosScreen.Load();
        }

        private static void List()
        {
            var repository = new UserRepository(Database.Connection);
            var items = repository.GetWithRoles();

            foreach(var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Email}");
                
                foreach(var role in item.Roles)
                {
                    Console.Write($"{role.Name} ");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}