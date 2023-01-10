using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudo_Dapper.Models;
using Estudo_Dapper.Repositories;

namespace Estudo_Dapper.Screens.UserScreens
{
    public class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Alterar usuário");
            Console.WriteLine("-------------");
            
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Password: ");
            var password = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Imagem: ");
            var image = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new User{
                Id = id,
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = image,
                Slug = slug
            });

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);

                Console.WriteLine("Usuário atualizado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao atualizar usuário!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}