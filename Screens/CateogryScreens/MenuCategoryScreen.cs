using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_Dapper.Screens.CateogryScreens
{
    public class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de categorias");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar categoria");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    CreateCategoryScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}