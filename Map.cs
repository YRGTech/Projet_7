using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Projet_7
{
    public class Map
    {
        string loadString;
        SerializeTheObject loadSave;

        const char _wall = (char)sprite.WALL;
        const char _wallup = (char)sprite.WALLUP;
        const char _floor = (char)sprite.FLOOR;
        const char _grass = (char)sprite.GRASS;
        const char _player = (char)sprite.PLAYER;
        const char _angleUL = (char)sprite.ANGLEUL;
        const char _angleUR = (char)sprite.ANGLEUR;
        const char _angleDL = (char)sprite.ANGLEDL;
        const char _angleDR = (char)sprite.ANGLEDR;




        // dimensions de la carte
        const int MAP_WIDTH = 50;
        const int MAP_HEIGHT = 20;

        char[,] _map = new char[MAP_HEIGHT, MAP_WIDTH] {
        { _angleUL, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup,_wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup,_wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup,_wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _angleUR },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _grass, _grass,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _grass, _grass,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _wall, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor,_floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _floor, _wall },
        { _angleDL, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup,_wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup,_wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup,_wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _wallup, _angleDR }
        };
       

        public Map()
        {
            loadString = File.ReadAllText("t.json");
            loadSave = JsonSerializer.Deserialize<SerializeTheObject>(loadString);
            playerX = loadSave.PosX + 2 ; 
            playerY = loadSave.PosY + 2;
        }

        public int playerX{ get; set;}

        public int playerY { get; set; }

        public bool IsValidMove(int x, int y)
        {
            // vérifie si les coordonnées sont dans les limites de la carte
            if (x < 0 || x >= MAP_WIDTH || y < 0 || y >= MAP_HEIGHT)
            {
                return false;
            }

            // vérifie si la case est un mur
            if (_map[y, x] == _wall || _map[y, x] == _wallup)
            {
                return false;
            }

            return true;
        }

        public void DrawMap()
        {
            // parcours de la carte
            for (int y = 0; y < MAP_HEIGHT; y++)
            {
                for (int x = 0; x < MAP_WIDTH; x++)
                {

                    if (x == playerX && y == playerY)
                    {// si c'est la position du joueur, on l'affiche
                        Console.Write(_player);
                    }
                    else
                    {// affichage du caractère de la carte
                        Console.Write(_map[y, x]);
                    }

                }
                // passage à la ligne suivante
                Console.WriteLine();
            }
        }
    }
}