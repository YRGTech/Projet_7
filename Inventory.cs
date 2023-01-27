using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Inventory
    {
        // ----------  Curseur dans le menu ---------
        int menu = 0;
        int posX = 0;
        int posY = 1;
        Pos pos = 0;

        // ----------  Nombre de potion ---------
        int SPotion = 0;
        int Potion = 0;
        int BPotion = 0;

        // ----------  Nombre de buff ---------
        int Cheetah = 0;
        int Tortoise = 0;
        int boeuf = 0;

        // ----------  Nombre de debuff
        // ................................................................................... ---------
        int Glue = 0;
        int Mirror = 0;
        int Pangolin = 0;


        public void inventory()
        {
            posX = 0;
            posY = 1;
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
            }
            menu = 0;
        }

        enum Pos
        {
            Potion = 1,
            Bouf = 2,
            Debouf = 21,

            Spotion = 101,
            MPotion = 102,
            BPotion = 121,

            boeuf = 201,
            Cheetah = 202,
            Tortoise = 221,

            Glue = 301,
            Mirror = 302,
            Pangolin = 321
            
        }

        void test()
        {
            switch (menu)
            {
                case 1:
                    pos+=100;
                    break;
                case 2:
                    pos += 200;
                    break;
                case 3:
                    pos += 300;
                    break;

            }
            switch (pos)
            {
                case Pos.Potion:
                    menu = 1;
                    potion();
                    break;
                case Pos.Bouf:
                    menu = 2;
                    bouf();
                    break;
                case Pos.Debouf:
                    menu = 3;
                    debouf();
                    break;
                default:
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
                Console.Write("  Big potion 100pv");
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
                    pos = (Pos)(posX + posY);
                    test();
                    break;
            }

        }
    }
}