using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace Projet_7
{
    public static class Inventory
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

            Pangolin = 310,
            Bat = 341,
        }


        public static int Menu { get; set; }
        public static int PosX { get; set; }
        public static int PosY { get; set; }
        public static Pos ppos { get; set; }

        public static Potion Potionnette { get; set; }
        public static Potion Potion { get; set; }
        public static Potion MaximaPocion { get; set; }

        public static Bouf Boeuf { get; set; }
        public static Bouf Mage { get; set; }
        public static Bouf Tortoise { get; set; }

        public static Debouf Pangolin { get; set; }
        public static Debouf Bat { get; set; }

        public static Pikachu Pikachu { get; set; }
        public static Pokemon Opponent { get; set; }

        public static void NewInventory(int menu, int posX, int posY, Pos pos,
            Potion potionnette, Potion mption, Potion bpotion,
            Bouf boeuf, Bouf mage, Bouf tortoise,
            Debouf pangolin, Debouf bat,
            Pikachu pikachu)
        {
            Menu = menu;
            PosX = posX;
            PosY = posY;
            ppos = pos;
            Potionnette = potionnette;
            Potion = mption;
            MaximaPocion = bpotion;
            Boeuf = boeuf;
            Mage = mage;
            Tortoise = tortoise;
            Pangolin = pangolin;
            Bat = bat;
            Pikachu = pikachu;

        }


        public static void Draw()
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
                Console.Write($"pv = {Pikachu.PV},\nPM = {Pikachu.PM},\ndef = {Pikachu.DEF},\natk = {Pikachu.ATK}");

                MoveCursor();
            }
            Menu = 0;


        }

        private static void MoveCursor()
        {
            // Input
            Console.SetCursorPosition(PosX, PosY);
            Console.Write("->");

            if (Menu == 3)
            {
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
                        PosX = 5;
                        break;

                    case ConsoleKey.RightArrow:
                        PosX = 36;
                        PosY = 5;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        ppos = (Pos)(PosX + PosY);
                        DetectClickLocation();
                        break;
                }
            }
            else
            {
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
        }

        static void DetectClickLocation()
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
                    Potionnette.Amount = Potionnette.usePotion(Potionnette.Amount, Potionnette.Description, Pikachu, Potionnette.Percentage, Potionnette.Name);
                    break;
                case Pos.MPotion:
                    Potion.Amount = Potion.usePotion(Potion.Amount, Potion.Description, Pikachu, Potion.Percentage, Potion.Name);
                    break;
                case Pos.BPotion:
                    MaximaPocion.Amount = MaximaPocion.usePotion(MaximaPocion.Amount, MaximaPocion.Description, Pikachu, MaximaPocion.Percentage, MaximaPocion.Name);
                    break;

                //Bouf
                case Pos.Boeuf:
                    Boeuf.Amount = Boeuf.useBoeuf(Boeuf.Amount, Boeuf.Description, Pikachu, Boeuf.Percentage, Boeuf.Name);
                    break;
                case Pos.Mage:
                    Mage.Amount = Mage.useMage(Mage.Amount, Mage.Description, Pikachu, Mage.Percentage, Mage.Name);
                    break;
                case Pos.Tortoise:
                    Tortoise.Amount = Tortoise.useTortoise(Tortoise.Amount, Tortoise.Description, Pikachu, Tortoise.Percentage, Tortoise.Name);
                    break;

                //Debouf
                case Pos.Bat:
                    Bat.Amount = Bat.useBat(Bat.Amount, Bat.Description, Pikachu, Bat.Percentage, Bat.Name);
                    break;
                case Pos.Pangolin:
                    Pangolin.Amount = Pangolin.usePangolin(Pangolin.Amount, Pangolin.Description, Pikachu, Pangolin.Percentage, Pangolin.Name);
                    break;
                default:
                    Return();
                    break;
            }
        }

        static void Return()
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



        public static void ShowPotion()
        {


            while (Menu == 1)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("\n\n                      Potion");
                Console.Write("\n\n\n");
                Console.Write("       " + Potionnette.Amount + "x Potionnette +20% des PV");
                Console.Write("     " + MaximaPocion.Amount + "x Maxima pocion +80% des PV\n");
                Console.Write("       " + Potion.Amount + "x Potion +50% des PV");
                Console.Write("          Quit");

                Console.SetCursorPosition(PosX, PosY);
                Console.Write("->");

                MoveCursor();
            }
        }

        static void ShowBouf()
        {
            while (Menu == 2)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("\n\n                      Bouf");
                Console.Write("\n\n\n");
                Console.Write("       " + Boeuf.Amount + "x boeuf +30% de dégat");
                Console.Write("         " + Mage.Amount + "x Mage +50% des PM\n");
                Console.Write("       " + Tortoise.Amount + "x tortoise +30% de défense");
                Console.Write("    Quit\n");

                Console.SetCursorPosition(PosX, PosY);
                Console.Write("->");

                MoveCursor();
            }
        }
        static void ShowDebouf()
        {
            while (Menu == 3)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("\n\n                      Debouf");
                Console.Write("\n\n\n");
                Console.Write("       " + Pangolin.Amount + "x Pangolin -30% Defence");
                Console.Write("       " + Bat.Amount + "x Bat -30% d'attaque\n");
                Console.Write("       Quit\n");

                Console.SetCursorPosition(PosX, PosY);
                Console.Write("->");

                MoveCursor();
            }
        }


    }
}