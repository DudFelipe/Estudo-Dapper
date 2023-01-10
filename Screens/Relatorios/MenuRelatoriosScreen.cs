using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_Dapper.Screens.Relatorios
{
    public class MenuRelatoriosScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Relatórios");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar usuários e suas roles");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    ListUserRoleScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}