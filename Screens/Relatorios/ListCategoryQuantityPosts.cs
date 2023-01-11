using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudo_Dapper.Repositories;

namespace Estudo_Dapper.Screens.Relatorios
{
    public class ListCategoryQuantityPosts
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Categorias e Posts");
            Console.WriteLine("-------------");

            List();

            Console.ReadKey();
            MenuRelatoriosScreen.Load();
        }

        private static void List()
        {
            var repository = new CategoryRepository(Database.Connection);
            var items = repository.GetCategoryWithPosts();

            foreach(var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Posts.Count}");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}