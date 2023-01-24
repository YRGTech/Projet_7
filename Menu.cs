using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Menu
    {
        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Team Summary");
            Console.WriteLine("2) Inventory");
            Console.WriteLine("3) Save");
            switch (Console.ReadLine())
            {
                case "1":
                    break;
                default:
                    break;
            }
        }
    }
}