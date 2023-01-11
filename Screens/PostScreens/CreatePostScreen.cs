using Estudo_Dapper.Models;
using Estudo_Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_Dapper.Screens.PostScreens
{
    public class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo post");
            Console.WriteLine("-------------");
            
            Console.Write("Category: ");
            var idCategory = int.Parse(Console.ReadLine());

            Console.Write("Author: ");
            var idAuthor = int.Parse(Console.ReadLine());

            Console.Write("Title: ");
            var title = Console.ReadLine();

            Console.Write("Summary: ");
            var summary = Console.ReadLine();

            Console.Write("Body: ");
            var body = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Post{
                CategoryId = idCategory,
                AuthorId = idAuthor,
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            });

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);

                Console.WriteLine("Post cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar post!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}