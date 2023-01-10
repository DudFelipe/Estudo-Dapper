using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudo_Dapper.Models;
using Estudo_Dapper.Repositories;

namespace Estudo_Dapper.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma tag");
            Console.WriteLine("-------------");
            
            Console.Write("Qual o id da tag que deseja excluir? ");
            var id = Console.ReadLine();
            
            Delete(int.Parse(id));

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag atualizada com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}