using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_7
{
    public class Inventory
    {

        

        public void inventory()
        {
            bool bool_inventory = true;

            while (bool_inventory)
            {
                Console.Clear();
                Console.Write("              Inventory");
                Console.Write("\n");
                Console.Write("  Potion");
                Console.Write("                   Potion\n");
                Console.Write("  Potion");
                Console.Write("                   Potion\n");
                Console.Write("  Quitter");

                // récupération de la touche appuyée par le joueur
                ConsoleKey key = Console.ReadKey(true).Key;

                // Séléction du type d'objet dans l'inventaire
                if (key == ConsoleKey.NumPad1)
                {

                }
                else if (key == ConsoleKey.NumPad2)
                {

                }
                else if (key == ConsoleKey.NumPad3)
                {

                }
                else if (key == ConsoleKey.NumPad4)
                {

                }
                else if (key == ConsoleKey.Q)
                {
                    bool_inventory = false;
                    
                }

                
                Console.Clear();

            }
        }
    }
}