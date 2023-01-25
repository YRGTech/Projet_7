using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Inventory
    {
        bool bool_inventory = true;
        int posX = 0;
        int posY = 1;
        int pos = 0;
        public void inventory()
        {
            bool bool_inventory = true;
            int posX = 0;
            int posY= 1;
            int pos = 0;
            Console.Clear();
            Console.CursorVisible = false;

            while (bool_inventory)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("          Inventory");
                Console.Write("\n");
                Console.Write("  Potion");
                Console.Write("              Bouf\n");
                Console.Write("  Debouf");
                Console.Write("              Quit\n");

                Console.SetCursorPosition(posX, posY);
                Console.Write("->");

                move(posX, posY, pos);
                
                
            }
        }

        void test(int posX, int posY, int pos)
        {
            switch (pos)
            {
                case (1):
                    potion(posX, posY, pos);
                    break;
                case (2):
                    bouf(posX, posY, pos); 
                    break;
                case (21):
                    debouf(posX, posY, pos);
                    break;
                case (22):
                    quit();
                    break;
            }
        }

        void potion(int posX, int posY, int pos)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("          Inventory");
            Console.Write("\n");
            Console.Write("  Potion");
            Console.Write("              Bouf\n");
            Console.Write("  Debouf");
            Console.Write("              Quit\n");

            Console.SetCursorPosition(posX, posY);
            Console.Write("->");

            move(posX, posY, pos);
        }
        void bouf(int posX, int posY, int pos)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("          Inventory");
            Console.Write("\n");
            Console.Write("  Potion");
            Console.Write("              Bouf\n");
            Console.Write("  Debouf");
            Console.Write("              Quit\n");

            Console.SetCursorPosition(posX, posY);
            Console.Write("->");

            move(posX, posY, pos);
        }
        void debouf(int posX, int posY, int pos)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("          Inventory");
            Console.Write("\n");
            Console.Write("  Potion");
            Console.Write("              Bouf\n");
            Console.Write("  Debouf");
            Console.Write("              Quit\n");

            Console.SetCursorPosition(posX, posY);
            Console.Write("->");

            move(posX, posY, pos);
        }
        void quit()
        {

        }

        void move(int posX, int posY, int pos)
        {

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
                    pos = posX + posY;
                    test(posX, posY, pos);
                    Console.Clear();
                    break;
            }

        }
    }
}