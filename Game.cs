using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_7
{
    internal class Game
    {
        public void Run()
        {
            // affichage de la carte initiale
            Map map = new Map();

            Console.Write("                                 ,'\\\r\n    _.----.        ____         ,'  _\\   ___    ___     ____\r\n_,-'       `.     |    |  /`.   \\,-'    |   \\  /   |   |    \\  |`.\r\n\\      __    \\    '-.  | /   `.  ___    |    \\/    |   '-.   \\ |  |\r\n \\.    \\ \\   |  __  |  |/    ,','_  `.  |          | __  |    \\|  |\r\n   \\    \\/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |\r\n    \\     ,-'/  /   \\    ,'   | \\/ / ,`.|         /  /   \\  |     |\r\n     \\    \\ |   \\_/  |   `-.  \\    `'  /|  |    ||   \\_/  | |\\    |\r\n      \\    \\ \\      /       `-.`.___,-' |  |\\  /| \\      /  | |   |\r\n       \\    \\ `.__,'|  |`-._    `|      |__| \\/ |  `.__,'|  | |   |\r\n        \\_.-'       |__|    `-._ |              '-.|     '-.| |   |\r\n                                `'                            '-._|");
            Pikachu pikachu = new Pikachu();

            bool openMenu = false;

            // boucle de jeu
            while (true && openMenu ==false)
            {
                // récupération de la touche appuyée par le joueur
                ConsoleKey key = Console.ReadKey(true).Key;

                // mise à jour de la position du joueur en fonction de la touche appuyée
                if (key == ConsoleKey.UpArrow)
                {
                    if (map.IsValidMove(map.playerX, map.playerY - 1))
                    {
                        map.playerY--;
                        Console.Clear();
                        map.DrawMap();
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (map.IsValidMove(map.playerX, map.playerY + 1))
                    {
                        map.playerY++;
                        Console.Clear();
                        map.DrawMap();
                    }
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    if (map.IsValidMove(map.playerX - 1, map.playerY))
                    {
                        map.playerX--;
                        Console.Clear();
                        map.DrawMap();
                    }
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    if (map.IsValidMove(map.playerX + 1, map.playerY))
                    {
                        map.playerX++;
                        Console.Clear();
                        map.DrawMap();
                    }
                }
                else if (key == ConsoleKey.X)
                {
                    Menu menu= new Menu();
                    menu.createMenu(map);
                    openMenu = true;
                }

            }
        }
        // fonction pour vérifier si un mouvement est valide

    }
}
