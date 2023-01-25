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
    internal class Game
    {



        public void Run()
        {
            // affichage de la carte initiale
            Map map = new Map();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("\r\n░█▀▀▄░░░░░░░░░░░▄▀▀█ ");
            Console.SetCursorPosition( 0,1);
            Console.WriteLine("\r\n░█░░░▀▄░▄▄▄▄▄░▄▀░░░█" );
            Console.SetCursorPosition( 0,2);
            Console.WriteLine("\r\n░░▀▄░░░▀░░░░░▀░░░▄▀");
            Console.SetCursorPosition( 0,3);
            Console.WriteLine("\r\n░░░░▌░▄▄░░░▄▄░▐▀▀");
            Console.SetCursorPosition(0,4);
            Console.WriteLine("\r\n░░░▐░░█▄░░░▄█░░▌▄▄▀▀▀▀█");
            Console.SetCursorPosition( 0,5);
            Console.WriteLine("\r\n░░░▌▄▄▀▀░▄░▀▀▄▄▐░░░░░░█");
            Console.SetCursorPosition( 0,6);
            Console.WriteLine("\r\n▄▀▀▐▀▀░▄▄▄▄▄░▀▀▌▄▄▄░░░█");
            Console.SetCursorPosition( 0,7);
            Console.WriteLine("\r\n█░░░▀▄░█░░░█░▄▀░░░░█▀▀▀");
            Console.SetCursorPosition( 0,8);
            Console.WriteLine("\r\n░▀▄░░▀░░▀▀▀░░▀░░░▄█▀");
            Console.SetCursorPosition( 0,9);
            Console.WriteLine("\r\n░░░█░░░░░░░░░░░▄▀▄░▀▄");
            Console.SetCursorPosition( 0,10);
            Console.WriteLine("\r\n░░░█░░░░░░░░░▄▀█░░█░░█");
            Console.SetCursorPosition( 0,11);
            Console.WriteLine("\r\n░░░█░░░░░░░░░░░█▄█░░▄▀");
            Console.SetCursorPosition( 0,12);
            Console.WriteLine("\r\n░░░█░░░░░░░░░░░████▀");
            Console.SetCursorPosition( 0, 13);
            Console.WriteLine("\r\n░░░▀▄▄▀▀▄▄▀▀▄▄▄█▀");


            Console.Write(" ________  ___  ___  __    ________  ___  __    _______      \r\n|\\   __  \\|\\  \\|\\  \\|\\  \\ |\\   __  \\|\\  \\|\\  \\ |\\  ___ \\     \r\n\\ \\  \\|\\  \\ \\  \\ \\  \\/  /|\\ \\  \\|\\  \\ \\  \\/  /|\\ \\   __/|    \r\n \\ \\   ____\\ \\  \\ \\   ___  \\ \\  \\\\\\  \\ \\   ___  \\ \\  \\_|/__  \r\n  \\ \\  \\___|\\ \\  \\ \\  \\\\ \\  \\ \\  \\\\\\  \\ \\  \\\\ \\  \\ \\  \\_|\\ \\ \r\n   \\ \\__\\    \\ \\__\\ \\__\\\\ \\__\\ \\_______\\ \\__\\\\ \\__\\ \\_______\\\r\n    \\|__|     \\|__|\\|__| \\|__|\\|_______|\\|__| \\|__|\\|_______|");
            Pikachu pikachu = new Pikachu();
            Pikachu pikachu2 = new Pikachu();
            Console.Write("pv pika debu : {0}", pikachu.PV);
            pikachu2.Attack(pikachu, pikachu2.Skill1);
            Console.Write("pv pika hurt: {0}", pikachu.PV);
            pikachu.LVLup();
            pikachu.LVLup();
            pikachu.LVLup();
            pikachu.LVLup();
            Console.Write("pv pika lvlup: {0}\n", pikachu.PV);
            pikachu.Draw();
            //var player = new SoundPlayer("path/to/audiofile.wav");
            //player.Play();
            bool start = false;
            // boucle de jeu
            while (true)
            {

                // récupération de la touche appuyée par le joueur
                ConsoleKey key = Console.ReadKey(true).Key;

                // mise à jour de la position du joueur en fonction de la touche appuyée
                switch (key)
                {
                    case ConsoleKey.Spacebar:
                        start = true;
                        Console.Clear();
                        map.DrawMap();
                        break;
                    case ConsoleKey.UpArrow:
                        map.playerY--;
                        break;
                    case ConsoleKey.DownArrow:
                        map.playerY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        map.playerX--;
                        break;
                    case ConsoleKey.RightArrow:
                        map.playerX++;
                        break;
                    default:
                        break;
                }

                if (start)
                {
                    // réaffichage de la carte avec la nouvelle position du joueur

                    Console.SetCursorPosition(0, 0);
                    map.DrawMap();
                }



            }
        }
        // fonction pour vérifier si un mouvement est valide

    }
}
