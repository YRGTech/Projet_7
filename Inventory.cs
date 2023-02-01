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
            Bat = 310,
        }


        public int Menu { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Pos ppos { get; set; }

        public Potion Potionnette { get; set; }
        public Potion MPotion { get; set; }
        public Potion BPotion { get; set; }

        public Bouf Boeuf { get; set; }
        public Bouf Mage { get; set; }
        public Bouf Tortoise { get; set; }

        public Debouf Pangolin { get; set; }
        public Debouf Bat { get; set; }

        public Pikachu Pikachu { get; set; }
        public Pokemon Opponent { get; set; }

        public Inventory(int menu, int posX, int posY, Pos pos , 
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
            MPotion = mption;
            BPotion = bpotion;
            Boeuf = boeuf;
            Mage = mage;
            Tortoise = tortoise;
            Pangolin = pangolin;
            Bat = bat;
            Pikachu= pikachu;

        }


        public void Draw()
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
                Console.Write($"pv = {Pikachu.PV}, PM = {Pikachu.PM}, def = {Pikachu.DEF}, atk = {Pikachu.ATK}");

                MoveCursor();
            }
            Menu = 0;


        }

        private void MoveCursor()
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
                    Potionnette.Amount = Potionnette.usePotion(Potionnette.Amount, Potionnette.Description,Pikachu,Potionnette.Percentage, Potionnette.Name);
                    break;
                case Pos.MPotion:
                    MPotion.Amount = MPotion.usePotion(MPotion.Amount, MPotion.Description, Pikachu, MPotion.Percentage, MPotion.Name); 
                    break;
                case Pos.BPotion:
                    BPotion.Amount = BPotion.usePotion(BPotion.Amount, BPotion.Description, Pikachu, BPotion.Percentage, BPotion.Name); 
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

        

        public void ShowPotion()
        {
           

            while (Menu == 1)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("\n\n                      Potion");
                Console.Write("\n\n\n");
                Console.Write("       " + Potionnette.Amount + "x Potionnette +20% des PV") ;
                Console.Write("     " + MPotion.Amount + "x Maxima pocion +80% des PV\n");
                Console.Write("       " + BPotion.Amount + "x Potion +50% des PV");
                Console.Write("          Quit");

                Console.SetCursorPosition(PosX, PosY);
                Console.Write("->");

                MoveCursor();
            }
        }

        void ShowBouf()
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
