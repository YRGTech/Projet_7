using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using static Serialized;

using System.Xml.Linq;
using System.Text.Json;


namespace Projet_7
{
    internal class Game
    {
        bool loop = true;
        string loadString;
        SerializeTheObject loadSave;

        // constantes pour les caractères ASCII de la carte
        const char WALL = '#';
        const char FLOOR = '.';
        const char GRASS = '"';
        const char PLAYER = '@';
        const char PNJ = '☻';

        // dimensions de la carte
        const int MAP_WIDTH = 20;
        const int MAP_HEIGHT = 20;

        // position initiale du joueur
        int playerX;
        int playerY;

        // la carte
        char[,] map = new char[MAP_HEIGHT, MAP_WIDTH] {
        { WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, PNJ, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, GRASS, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, GRASS, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, GRASS, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, GRASS, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, FLOOR, WALL },
        { WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL, WALL }
    };

        public Game()
        {
            loadString = File.ReadAllText("t.json");
            loadSave = JsonSerializer.Deserialize<SerializeTheObject>(loadString);
            playerX = loadSave.posX;
            playerY = loadSave.posY;
        }
        public void Run()
        {

            // affichage de la carte initiale
            DrawMap();
            new Game();

            // boucle de jeu
            while (loop)
            {
                // récupération de la touche appuyée par le joueur
                ConsoleKey key = Console.ReadKey(true).Key;

                // mise à jour de la position du joueur en fonction de la touche appuyée
                if (key == ConsoleKey.UpArrow)
                {
                    if (IsValidMove(playerX, playerY - 1))
                    {
                        playerY--;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (IsValidMove(playerX, playerY + 1))
                    {
                        playerY++;
                    }
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    if (IsValidMove(playerX - 1, playerY))
                    {
                        playerX--;
                    }
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    if (IsValidMove(playerX + 1, playerY))
                    {
                        playerX++;
                    }
                }
                else if (key == ConsoleKey.Escape)
                {
                    var position = new SerializeTheObject
                    {
                        posX = playerX,
                        posY = playerY
                        
                };
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonString = JsonSerializer.Serialize(position, options);
                    File.WriteAllText("t.json", jsonString);
                    loop = false;
                }

                // réaffichage de la carte avec la nouvelle position du joueur
                Console.Clear();
                DrawMap();
            }
        }
        // fonction pour vérifier si un mouvement est valide
        bool IsValidMove(int x, int y)
        {
            // vérifie si les coordonnées sont dans les limites de la carte
            if (x < 0 || x >= MAP_WIDTH || y < 0 || y >= MAP_HEIGHT)
            {
                return false;
            }

            // vérifie si la case est un mur
            if (map[y, x] == WALL)
            {
                return false;
            }

            return true;
        }
        // fonction pour dessiner la carte
        void DrawMap()
        {
            // parcours de la carte
            for (int y = 0; y < MAP_HEIGHT; y++)
            {
                for (int x = 0; x < MAP_WIDTH; x++)
                {

                    if (x == playerX && y == playerY)
                    {// si c'est la position du joueur, on l'affiche
                        Console.Write(PLAYER + " ");
                    }
                    else
                    {// affichage du caractère de la carte
                        Console.Write(map[y, x] + " ");
                    }

                }
                // passage à la ligne suivante
                Console.WriteLine();
            }
        }

    }
}
