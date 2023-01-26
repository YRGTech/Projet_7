using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Inventory
    {
        bool bool_inventory = true;
        bool bool_potion = false;
        bool bool_bouf = false;
        bool bool_debouf = false;
        int menu = 0;
        int posX = 0;
        int posY = 1;
        int pos = 0;
        public void inventory()
        {
            bool bool_inventory = true;
            int posX = 0;
            int posY = 1;
            int pos = 0;
            Console.Clear();
            Console.CursorVisible = false;

            while (menu == 0)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("          Inventory");
                Console.Write("\n");
                Console.Write("  Potion");
                Console.Write("              Debouf\n");
                Console.Write("  Bouf");
                Console.Write("                Quit\n");

                move();
                Console.SetCursorPosition(posX, posY);
                Console.Write("->");
            }
            menu = 0;
        }

        void test()
        {
            switch (pos)
            {
                case (1):
                    menu = 1;
                    potion();
                    break;
                case (2):
                    menu = 2;
                    bouf();
                    break;
                case (21):
                    menu = 3;
                    debouf();
                    break;
                case (22):
                    quit();
                    break;
            }
        }

        void potion()
        {
            while (menu == 1)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("          Potion");
                Console.Write("\n");
                Console.Write("  small potion 20pv");
                Console.Write("   potion 50pv\n");
                Console.Write("  Big potion 100");
                Console.Write("      Quit\n");

                Console.SetCursorPosition(posX, posY);
                Console.Write("->");

                move();
            }
        }
        void bouf()
        {
            while (menu == 2)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("          Bouf");
                Console.Write("\n");
                Console.Write("  boeuf +damage");
                Console.Write("       Cheetah +dodge\n");
                Console.Write("  tortoise +defence");
                Console.Write("   Quit\n");

                Console.SetCursorPosition(posX, posY);
                Console.Write("->");

                move();
            }
        }
        void debouf()
        {
            while (menu == 3)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("          Debouf");
                Console.Write("\n");
                Console.Write("  Pangolin -Defence");
                Console.Write("   Mirror *can attack himself\n");
                Console.Write("  GlueGun no dodge");
                Console.Write("   Quit\n");

                Console.SetCursorPosition(posX, posY);
                Console.Write("->");

                move();
            }
        }
        void quit()
        {
            switch (menu)
            {
                case (0):
                    menu = 5;
                    break;
                case (1):
                    menu = 0;
                    break;
                case (2):
                    menu = 0;
                    break;
                case (3):
                    menu = 0;
                    break;
            }
        }

        void move()
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write("->");

            // récupération de la touche appuyée par le joueur
            ConsoleKey key = Console.ReadKey(true).Key;

            // Séléction du type d'objet dans l'inventaire
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    posY = 1;
                    break;

                case ConsoleKey.LeftArrow:
                    posX = 0;
                    break;

                case ConsoleKey.DownArrow:
                    posY = 2;
                    break;

                case ConsoleKey.RightArrow:
                    posX = 20;
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    pos = posX + posY;
                    test();
                    break;
            }

        }
    }
}