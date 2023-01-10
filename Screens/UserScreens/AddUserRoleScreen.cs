using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudo_Dapper.Models;
using Estudo_Dapper.Repositories;

namespace Estudo_Dapper.Screens.UserScreens
{
    public class AddUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular perfil de usuário");
            Console.WriteLine("-------------");
            
            Console.Write("Id do usuário: ");
            var idUser = int.Parse(Console.ReadLine());

            Console.Write("Id do perfil: ");
            var idRole = int.Parse(Console.ReadLine());

            Create(idUser, idRole);

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void Create(int idUser, int idRole)
        {
            try
            {
                var repository = new UserRepository(Database.Connection);
                repository.AddUserRole(idUser, idRole);

                Console.WriteLine("Usuário e Perfil vinculados com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao vincular usuário de usuário!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}