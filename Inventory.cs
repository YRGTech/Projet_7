using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace Projet_7
{
    public class Inventory
    {
        public enum Pos
        {
            Potion = 10,
            Bouf = 11,
            Debouf = 41,

            SPotion = 110,
            MPotion = 111,
            BPotion = 141,

            Boeuf = 210,
            Mage = 241,
            Tortoise = 211,

            Pangolin = 341,
            Bat = 311,
        }


        public int Menu { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Pos ppos { get; set; }

        public Inventory(int menu, int posX, int posY, Pos pos)
        {
            Menu = menu;
            PosX = posX;
            PosY = posY;
            ppos = pos;
        }


        internal void Draw()
        {
            PosX = 5;
            PosY = 5;
            Console.Clear();
            Console.CursorVisible = false;

            while (Menu == 0)
            {
                // Draw
                Console.SetCursorPosition(0, 0);
                Console.Write("\n\n                      Inventory");
                Console.Write("\n\n\n");
                Console.Write("       Potion");
                Console.Write("                         Debouf\n");
                Console.Write("       Bouf");
                Console.Write("                           Quit\n");

                MoveCursor();
            }
            Menu = 0;


        }

        private void MoveCursor()
        {
            // Input
            Console.SetCursorPosition(PosX, PosY);
            Console.Write("->");
            ConsoleKey key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    PosY = 5;
                    break;

                case ConsoleKey.LeftArrow:
                    PosX = 5;
                    break;

                case ConsoleKey.DownArrow:
                    PosY = 6;
                    break;

                case ConsoleKey.RightArrow:
                    PosX = 36;
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    ppos = (Pos)(PosX + PosY);
                    DetectClickLocation();
                    break;
            }
        }

        void DetectClickLocation()
        {
            switch (Menu)
            {
                case 1:
                    ppos += 100;
                    break;
                case 2:
                    ppos += 200;
                    break;
                case 3:
                    ppos += 300;
                    break;
            }

            switch (ppos)
            {
                //Menu principal
                case Pos.Potion:
                    Menu = 1;
                    ShowPotion();
                    break;
                case Pos.Bouf:
                    Menu = 2;
                    ShowBouf();
                    break;
                case Pos.Debouf:
                    Menu = 3;
                    ShowDebouf();
                    break;

                //Potion
                case Pos.SPotion:
                    Menu = 1;
                    break;
                case Pos.MPotion:
                    Menu = 2;
                    ShowBouf();
                    break;
                case Pos.BPotion:
                    Menu = 3;
                    ShowDebouf();
                    break;

                //Bouf
                case Pos.Boeuf:
                    Menu = 1;
                    ShowPotion();
                    break;
                case Pos.Mage:
                    Menu = 2;
                    ShowBouf();
                    break;
                case Pos.Tortoise:
                    Menu = 3;
                    ShowDebouf();
                    break;

                //Debouf
                case Pos.Bat:
                    Menu = 1;
                    ShowPotion();
                    break;
                case Pos.Pangolin:
                    Menu = 2;
                    ShowBouf();
                    break;
                default:
                    Return();
                    break;
            }
        }

        void Return()
        {
            switch (Menu)
            {
                case 0:
                    Menu = 5;
                    break;
                case 1:
                    Menu = 0;
                    break;
                case 2:
                    Menu = 0;
                    break;
                case 3:
                    Menu = 0;
                    break;
            }
            PosX = 5;
            PosY = 5;
        }

        public int GetAmount(Potion potion)
        {
            Potion potionn = potion;
            int number = potion.Amount;
            return number;
        }

        public int ShowPotion()
        {
            Potion potionnette = new Potion("Potionnette", 3, "ça régène un peu mais pas bcp", 20);
            int oui = potionnette.Amount;
            return oui;
            /*while (Menu == 1)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("\n\n                      Potion");
                Console.Write("\n\n\n");
                Console.Write("       " + oui + "x Potionnette 20pv") ;
                //Console.Write("            " + MaximaPocion + "x Maxima pocion 150pv\n");
                //Console.Write("       " + MPotion + "x Potion 50pv");
                Console.Write("                 Quit");

                Console.SetCursorPosition(PosX, PosY);
                Console.Write("->");

                MoveCursor();
            }*/
        }

        void ShowBouf()
        {
            while (Menu == 2)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("\n\n                      Bouf");
                Console.Write("\n\n\n");
                //Console.Write("       " + Boeuf + "x boeuf +damage");
                //Console.Write("               " + Cheetah + "x Cheetah +dodge\n");
                //Console.Write("       " + Tortoise + "x tortoise +defence");
                Console.Write("           Quit\n");

                Console.SetCursorPosition(PosX,PosY);
                Console.Write("->");

                MoveCursor();
            }
        }
        void ShowDebouf()
        {
            while (Menu == 3)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("\n\n                      Debouf");
                Console.Write("\n\n\n");
                //Console.Write("       " + Pangolin + "x Pangolin -Defence");
                //Console.Write("           " + Mirror + "x Mirror *can attack himself\n");
                //Console.Write("       " + Glue + "x GlueGun no dodge");
                Console.Write("            Quit\n");

                Console.SetCursorPosition(PosX, PosY);
                Console.Write("->");

                MoveCursor();
            }
        }


    }
}
