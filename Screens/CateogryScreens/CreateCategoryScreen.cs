using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudo_Dapper.Models;
using Estudo_Dapper.Repositories;

namespace Estudo_Dapper.Screens.CateogryScreens
{
    public class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova categoria");
            Console.WriteLine("-------------");
            
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category{
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);

                Console.WriteLine("Categoria cadastrada com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar categoria!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}