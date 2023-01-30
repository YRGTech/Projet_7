using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Projet_7
{
    public class Inventory
    {
        public Inventory()
        {
            int menu = 0;
            int posX = 0;
            int posY = 1;
            Pos pos = new Pos();

        }

        //----------  Postion des boutons  --------
        enum Pos
        {
            Potion = 10,
            Bouf = 11,
            Debouf = 41,

            SPotion = 110,
            MPotion = 111,
            BPotion = 141,

            Boeuf = 210,
            Cheetah = 241,
            Tortoise = 211,

            Glue = 341,
            Mirror = 311,
            Pangolin = 310

        }
    }


    // ---------------------------------------------------------------  Affichage des différents menu  -----------------------------------------------------
    public void inventory()
    {
        posX = 5;
        posY = 5;
        Console.Clear();
        Console.CursorVisible = false;

        while (menu == 0)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("\n\n                      Inventory");
            Console.Write("\n\n\n");
            Console.Write("       Potion");
            Console.Write("                         Debouf\n");
            Console.Write("       Bouf");
            Console.Write("                           Quit\n");

            move();
        }
        menu = 0;
    }

    void potion()
    {
        while (menu == 1)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("\n\n                      Potion");
            Console.Write("\n\n\n");
            Console.Write("       " + Potionnette + "x Potionnette 20pv");
            Console.Write("            " + MaximaPocion + "x Maxima pocion 150pv\n");
            Console.Write("       " + Potion + "x Potion 50pv");
            Console.Write("                 Quit");

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
            Console.Write("\n\n                      Bouf");
            Console.Write("\n\n\n");
            Console.Write("       " + Boeuf + "x boeuf +damage");
            Console.Write("               " + Cheetah + "x Cheetah +dodge\n");
            Console.Write("       " + Tortoise + "x tortoise +defence");
            Console.Write("           Quit\n");

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
            Console.Write("\n\n                      Debouf");
            Console.Write("\n\n\n");
            Console.Write("       " + Pangolin + "x Pangolin -Defence");
            Console.Write("           " + Mirror + "x Mirror *can attack himself\n");
            Console.Write("       " + Glue + "x GlueGun no dodge");
            Console.Write("            Quit\n");

            Console.SetCursorPosition(posX, posY);
            Console.Write("->");

            move();
        }
    }




    // --------------------------------------------------------------------  Control de la souris  ---------------------------------------------------------
    void move()
    {

        Console.SetCursorPosition(posX, posY);
        Console.Write("->");


        ConsoleKey key = Console.ReadKey(true).Key;
        switch (key)
        {
            case ConsoleKey.UpArrow:
                posY = 5;
                break;

            case ConsoleKey.LeftArrow:
                posX = 5;
                break;

            case ConsoleKey.DownArrow:
                posY = 6;
                break;

            case ConsoleKey.RightArrow:
                posX = 36;
                break;
            case ConsoleKey.Enter:
                Console.Clear();
                pos = (Pos)(posX + posY);
                test();
                break;
        }

    }


    // ---------------------------------------------------------------------  Action au click  --------------------------------------------------------------------
    void test()
    {
        switch (menu)
        {
            case 1:
                pos += 100;
                break;
            case 2:
                pos += 200;
                break;
            case 3:
                pos += 300;
                break;
        }
        useItem();

        switch (pos)
        {
            //Menu principal
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
            posX = 5;
            posY = 5;
        }
    }
}
