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

        public int MAP_WIDTH { get => lines.Length; }
        public int MAP_HEIGHT { get => firstLine.Length; }

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
            _map = new char[MAP_WIDTH, MAP_HEIGHT];
            for (int y = 0; y < MAP_WIDTH; y++)
            {
                string line = lines[y];
                for (int x = 0; x < MAP_HEIGHT; x++)
                {
                    char c = line[x];
                    if (c == '&') { playerX = x; playerY = y; _map[y, x] = _floor; }
                    else _map[y, x] = c;

                }
            }
        }


        public bool IsValidMove(int x, int y)
        {
            // vérifie si les coordonnées sont dans les limites de la carte
            if (x < 0 || x >= MAP_HEIGHT || y < 0 || y >= MAP_WIDTH)
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
            for (int y = 0; y < MAP_WIDTH; y++)
            {
                for (int x = 0; x < MAP_HEIGHT; x++)
                {
                    // affichage du caractère de la carte
                    if (_map[y, x] == _floor)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(_map[y, x]);
                }
                // passage à la ligne suivante
                Console.WriteLine();
            }
        }

        public void UpdatePlayerPos(int x, int y)
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(_map[playerY, playerX]);
            Console.SetCursorPosition(x, y);
            Console.Write(_player);
            playerX = x;
            playerY = y;

        }
    }
}