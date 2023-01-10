using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudo_Dapper.Models;
using Estudo_Dapper.Repositories;

namespace Estudo_Dapper.Screens.UserScreens
{
    public class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar usuário");
            Console.WriteLine("-------------");
            
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);

                Console.WriteLine("Usuário deletado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao deletar usuário!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}