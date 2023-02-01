using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace Projet_7
{
    internal class Game
    {
        public bool loop;

        Inventory _inventory;

        public void Run()
        {
            // affichage de la carte initiale
            Map map = new Map();
            Console.Write("                                 ,'\\\r\n    _.----.        ____         ,'  _\\   ___    ___     ____\r\n_,-'       `.     |    |  /`.   \\,-'    |   \\  /   |   |    \\  |`.\r\n\\      __    \\    '-.  | /   `.  ___    |    \\/    |   '-.   \\ |  |\r\n \\.    \\ \\   |  __  |  |/    ,','_  `.  |          | __  |    \\|  |\r\n   \\    \\/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |\r\n    \\     ,-'/  /   \\    ,'   | \\/ / ,`.|         /  /   \\  |     |\r\n     \\    \\ |   \\_/  |   `-.  \\    `'  /|  |    ||   \\_/  | |\\    |\r\n      \\    \\ \\      /       `-.`.___,-' |  |\\  /| \\      /  | |   |\r\n       \\    \\ `.__,'|  |`-._    `|      |__| \\/ |  `.__,'|  | |   |\r\n        \\_.-'       |__|    `-._ |              '-.|     '-.| |   |\r\n                                `'                            '-._|");
            Pikachu pikachu = new Pikachu();
            Potion potionnette = new Potion("Potionnette", 3, "ça régène un peu de PV mais pas bcp", 20);
            Potion potion = new Potion("potion", 3, "ça régène des PV", 50);
            Potion MaximaPocion= new Potion("MaximaPocion", 3, "ça régène bcp wallah", 80);
            Bouf Mage = new Bouf("Mage", 3, "Manger un mage vous fait regagner des PM", 40);
            Bouf Tortoise = new Bouf("Tortoise", 3, "Manger une tortue vous augmente votre défense", 20);
            Bouf Boeuf = new Bouf("Boeuf", 3, "Manger un boeuf vous augmente votre attaque", 20);
            Debouf Pangolin = new Debouf("Pangolin", 3, "Vous donnez un pangolain à manger à votre ennemi, il attrape le variant Delta du covid19, sa défense baisse", 20, 3);
            Debouf Bat = new Debouf("Bat", 3, "Vous donnez une chauve-souris à manger à votre ennemi, il attrape le variant Alpha du covid19, son attaque baisse", 20,3);
            




            _inventory = new Inventory(10,5,5,0,potionnette,potion, MaximaPocion, Boeuf,Mage,Tortoise,Pangolin,Bat,pikachu);            

            loop = true;

         

            // boucle de jeu
            while (loop)
            {
                // récupération de la touche appuyée par le joueur
                ConsoleKey key = Console.ReadKey(true).Key;

                // mise à jour de la position du joueur en fonction de la touche appuyée
                if (key == ConsoleKey.UpArrow)
                {
                    if (map.IsValidMove(map.playerX, map.playerY - 1))
                    {
                        map.playerY--;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (map.IsValidMove(map.playerX, map.playerY + 1))
                    {
                        map.playerY++;
                    }
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    if (map.IsValidMove(map.playerX - 1, map.playerY))
                    {
                        map.playerX--;
                    }
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    if (map.IsValidMove(map.playerX + 1, map.playerY))
                    {
                        map.playerX++;
                    }
                }
                else if (key == ConsoleKey.I)
                {
                    _inventory.Draw();
                }

                // réaffichage de la carte avec la nouvelle position du joueur
                Console.SetCursorPosition(0,0);
                map.DrawMap();
            }
        }
        // fonction pour vérifier si un mouvement est valide

    }
}
