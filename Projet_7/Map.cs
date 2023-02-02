namespace Projet_7
{
    public class Map
    {

        const char _wall = (char)sprite.WALL;
        const char _wallup = (char)sprite.WALLUP;
        const char _floor = (char)sprite.FLOOR;
        const char _grass = (char)sprite.GRASS;
        const char _player = (char)sprite.PLAYER;

        // dimensions de la carte
        string[] lines;
        string firstLine;

        public int MAP_HEIGHT { get => lines.Length; }
        public int MAP_WIDTH { get => firstLine.Length; }

        char[,] _map;

        public int playerX
        {
            get;
            set;

        }

        public int playerY
        {
            get;
            set;
        }


        public Map()
        {
            lines = File.ReadAllLines("map.txt");
            firstLine = lines[0];
            _map = new char[MAP_HEIGHT, MAP_WIDTH];
            for (int y = 0; y < MAP_HEIGHT; y++)
            {
                string line = lines[y];
                for (int x = 0; x < MAP_WIDTH; x++)
                {
                    char c = line[x];
                    if (c == '&') { playerX = x; playerY = y; _map[y, x] = _floor; }
                    else _map[y, x] = c;

                }
            }
        }
        public void ResetPlayer()
        {
            for (int y = 0; y<MAP_HEIGHT; y++)
            {
                string line = lines[y];
                for (int x = 0; x<MAP_WIDTH; x++)
                {
                    char c = line[x];
                    if (c == '&') { playerX = x; playerY = y; }
                }
            }
        }

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
                    // affichage du caractère de la carte
                    if (_map[y, x] == _floor)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (_map[y, x] == _grass)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (_map[y, x] == (char)sprite.ITEM)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if(_map[y, x] == _wall || _map[y, x] == _wallup)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    Console.Write(_map[y, x]);
                }
                // passage à la ligne suivante
                Console.WriteLine();
            }
        }

        public void UpdatePlayerPos(int x, int y)
        {
            Console.SetCursorPosition(playerX, playerY);
            if (_map[playerY, playerX] == _floor)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (_map[playerY, playerX] == _grass)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else if (_map[playerY, playerX] == (char)sprite.ITEM)
            {
                if (_map[y, x] == _floor)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Green;
                    _map[playerY, playerX] = _floor;
                }
                else {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    _map[playerY, playerX] = _grass;
                }
            }
            Console.Write(_map[playerY, playerX]);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(_player);
            playerX = x;
            playerY = y;

        }

        public bool IsPlayerOnGrass()
        {
            if (_map[playerY, playerX] == _grass)
            {
                return true;
            }
            return false;
        }
        public bool IsPlayerOnItem()
        {
            if (_map[playerY, playerX] == (char)sprite.ITEM)
            {
                return true;
            }
            return false;
        }
    }
}