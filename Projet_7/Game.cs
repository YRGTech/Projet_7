using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Projet_7
{
    public class Game
    {
        public bool OpenMenu { get; set; }
        public bool Explo { get; set; }
        public Map? Map { get; set; }

        public void Run()
        {
            Menu menu = new Menu();
            // affichage de la carte initiale
            Map = new Map();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("\r\n░█▀▀▄░░░░░░░░░░░▄▀▀█ ");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("\r\n░█░░░▀▄░▄▄▄▄▄░▄▀░░░█");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("\r\n░░▀▄░░░▀░░░░░▀░░░▄▀");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("\r\n░░░░▌░▄▄░░░▄▄░▐▀▀");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("\r\n░░░▐░░█▄░░░▄█░░▌▄▄▀▀▀▀█");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("\r\n░░░▌▄▄▀▀░▄░▀▀▄▄▐░░░░░░█");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("\r\n▄▀▀▐▀▀░▄▄▄▄▄░▀▀▌▄▄▄░░░█");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("\r\n█░░░▀▄░█░░░█░▄▀░░░░█▀▀▀");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("\r\n░▀▄░░▀░░▀▀▀░░▀░░░▄█▀");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("\r\n░░░█░░░░░░░░░░░▄▀▄░▀▄");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("\r\n░░░█░░░░░░░░░▄▀█░░█░░█");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("\r\n░░░█░░░░░░░░░░░█▄█░░▄▀");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("\r\n░░░█░░░░░░░░░░░████▀");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("\r\n░░░▀▄▄▀▀▄▄▀▀▄▄▄█▀");


            Console.Write(" ________  ___  ___  __    ________  ___  __    _______      \r\n|\\   __  \\|\\  \\|\\  \\|\\  \\ |\\   __  \\|\\  \\|\\  \\ |\\  ___ \\     \r\n\\ \\  \\|\\  \\ \\  \\ \\  \\/  /|\\ \\  \\|\\  \\ \\  \\/  /|\\ \\   __/|    \r\n \\ \\   ____\\ \\  \\ \\   ___  \\ \\  \\\\\\  \\ \\   ___  \\ \\  \\_|/__  \r\n  \\ \\  \\___|\\ \\  \\ \\  \\\\ \\  \\ \\  \\\\\\  \\ \\  \\\\ \\  \\ \\  \\_|\\ \\ \r\n   \\ \\__\\    \\ \\__\\ \\__\\\\ \\__\\ \\_______\\ \\__\\\\ \\__\\ \\_______\\\r\n    \\|__|     \\|__|\\|__| \\|__|\\|_______|\\|__| \\|__|\\|_______|");


            //var player = new SoundPlayer("path/to/audiofile.wav");
            //player.Play();

            // boucle de jeu
            while (true && OpenMenu == false)
            {
                // récupération de la touche appuyée par le joueur
                ConsoleKey key = Console.ReadKey(true).Key;

                // mise à jour de la position du joueur en fonction de la touche appuyée


                switch (key)
                {
                    case ConsoleKey.Spacebar:
                        Explo = true;
                        Console.Clear();
                        Map.DrawMap();
                        break;
                    case ConsoleKey.UpArrow:
                        Map.playerY--;
                        break;
                    case ConsoleKey.DownArrow:
                        Map.playerY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        Map.playerX--;
                        break;
                    case ConsoleKey.RightArrow:
                        Map.playerX++;
                        break;
                    case ConsoleKey.X:
                        Explo = false;
                        OpenMenu = true;
                        break;
                    default:
                        break;
                }

                if (Explo)
                {
                    // réaffichage de la carte avec la nouvelle position du joueur

                    Console.SetCursorPosition(0, 0);
                    Map.DrawMap();
                }
                else if (OpenMenu)
                {
                    menu.createMenu(this);

                }



            }
        }
        // fonction pour vérifier si un mouvement est valide

    }
}
