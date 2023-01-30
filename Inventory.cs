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
        bool canMove = true;

        // ----------  Nombre de potion ---------
        int Potionnette = 3;
        int Potion = 3;
        int MaximaPocion = 3;

        // ----------  Nombre de buff  ---------
        int Cheetah = 3;
        int Tortoise = 3;
        int Boeuf = 3;

        // ----------  Nombre de debuff  ---------
        int Glue = 3;
        int Mirror = 3;
        int Pangolin = 3;

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

            Glue = 310,
            Mirror = 311,
            Pangolin = 341

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

        void useItem() // ---------------------------------------------  Use Item --------------------------------------------------------------
        {
            if ((int)pos > 99) canMove = false; 
            switch (pos)
            {

                case Pos.SPotion: // ---------------------  Potion ----------------------------
                    if (Potionnette > 0)
                    {
                        Potionnette--;
                        // Pokemon.Heal
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You regain 25Hp");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Potionnette + " Potionnette left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        canMove = true;
                    }
                    else if (Potionnette == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Potionette");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();
                        canMove = true;

                    }
                    break;

                case Pos.MPotion:
                    if (Potion > 0)
                    {
                        Potion--;
                        // Pokemon.Heal
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You regain 50Hp");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Potion + " Potion left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        canMove = true;
                    }
                    else if (Potion == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Potion");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();
                        canMove = true;

                    }
                    break;
                case Pos.BPotion:
                    if (MaximaPocion > 0)
                    {
                        MaximaPocion--;
                        // Pokemon.Heal
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You regain 150Hp");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(MaximaPocion + " Maxima Pocion left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        canMove = true;
                    }
                    else if (MaximaPocion == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Maxima Pocion");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();
                        canMove = true;

                    }
                    break;


                case Pos.Boeuf:  // ---------------------  Bouf ----------------------------
                    if (Boeuf > 0)
                    {
                        Boeuf--;
                        // Pokemon.atk increase
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You're attack increase by 50%");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Boeuf + " Boeuf left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        canMove = true;
                    }
                    else if (Boeuf == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Boeuf");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();
                        canMove = true;

                    }
                    break;

                case Pos.Cheetah:
                    if (Cheetah > 0)
                    {
                        Cheetah--;
                        // Pokemon.dodge increase
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You're chance of dodge increase by 40%");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Cheetah + " Cheetah left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        canMove = true;
                    }
                    else if (Cheetah == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Cheetah");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();
                        canMove = true;

                    }
                    break;

                case Pos.Tortoise:
                    if (Tortoise > 0)
                    {
                        Tortoise--;
                        // Pokemon.shield increase
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You're shield increase by 30%");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Tortoise + " Tortoise left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        canMove = true;
                    }
                    else if (Tortoise == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Tortoise");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();
                        canMove = true;

                    }
                    break;

                case Pos.Glue:  // ---------------------  Debouf ----------------------------
                    if (Glue > 0)
                    {
                        Glue--;
                        // Pokemon.atk increase
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You're opponent can't dodge or escape");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Glue + " Glue left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        canMove = true;
                    }
                    else if (Glue == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Glue");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();
                        canMove = true;

                    }
                    break;

                case Pos.Mirror:
                    if (Mirror > 0)
                    {
                        Mirror--;
                        // Pokemon.dodge increase
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You're opponent have 50% of attacking himself");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Mirror + " Mirror left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        canMove = true;
                    }
                    else if (Mirror == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Mirror");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();
                        canMove = true;

                    }
                    break;


                case Pos.Pangolin:
                    if (Pangolin > 0)
                    {
                        Pangolin--;
                        // opponent.shield decrease
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Opponent shild decrease by 30%");
                        Console.SetCursorPosition(30, 9);
                        Console.Write(Pangolin + " Pangolin left");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        canMove = true;
                    }
                    else if (Pangolin == 0)
                    {
                        Console.SetCursorPosition(30, 8);
                        Console.Write("You don't have any Pangolin");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.SetCursorPosition(30, 8);
                        Console.Write(" You idiot");
                        System.Threading.Thread.Sleep(800);
                        Console.Clear();
                        canMove = true;

                    }
                    break;

                default:
                    break;
            }
            

        }


        // --------------------------------------------------------------------  Control de la souris  ---------------------------------------------------------
        void move()
        {

            Console.SetCursorPosition(posX, posY);
            Console.Write("->");
            
            if (canMove)
            {
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
}