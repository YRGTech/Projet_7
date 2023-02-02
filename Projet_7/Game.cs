using System.Numerics;

namespace Projet_7
{
    public class Game
    {
        private bool _start = true;
        private bool _lose;
        private bool _win;
        public bool OpenMenu { get; set; }
        public bool Explo { get; set; }
        public Map? Map { get; set; }
        public Pikachu? Pikachu { get; set; }
      
        public Game() {
            Map = new Map();

            Pikachu = new PikachuDresseur();
        }
        

        public void Run()
        {
            Menu menu = new Menu();
        Start:
            StartScreen();
            // boucle de jeu
            while (true)
            {
                if (_start)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;


                    switch (key)
                    {
                        case ConsoleKey.Spacebar:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            if (_lose) { StartScreen(); _lose = false; Map.ResetPlayer(); Pikachu = new PikachuDresseur(); }
                            else
                            {
                                _start = false;
                                Explo = true;
                                Map.DrawMap();
                                Map.UpdatePlayerPos(Map.playerX, Map.playerY);
                            }
                            break;
                        default:
                            break;
                    }

                }
                else if (Explo)
                {
                    MovePlayer();


                }
                else if (OpenMenu)
                {

                    menu.CreateMenu(this);

                }
            }
        }

        public void StartCombat()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Combat c = new Combat(Pikachu);
            c.Fight();
            _win = c.win;
            _lose = c.lose;
            _start = true;
            if (c.LVLUP > 0)
            {
                LVLUPScreen();
                c.LVLUP--;
            }


        }
        public void WinScreen()
        {
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) - 4);
            Console.WriteLine("(  (                 \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) - 3);
            Console.WriteLine(" )\\))(   ' (          \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) - 2);
            Console.WriteLine("((_)()\\ )  )\\   (     \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) - 1);
            Console.WriteLine("_(())\\_)()((_)  )\\ )  \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) - 0);
            Console.WriteLine("\\ \\((_)/ / (_) _(_/(  \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) + 1);
            Console.WriteLine(" \\ \\/\\/ /  | || ' \\)) \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) + 2);
            Console.WriteLine("  \\_/\\_/   |_||_||_|  \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) + 3);
            Console.WriteLine("                      \r\n");
        }
        public void LoseScreen()
        {
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth / 2) - 30, (Console.WindowHeight / 2) - 4);
            Console.WriteLine(" ▄█        ▄██████▄     ▄████████    ▄████████    ▄████████ \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 30, (Console.WindowHeight / 2) - 3);
            Console.WriteLine("███       ███    ███   ███    ███   ███    ███   ███    ███ \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 30, (Console.WindowHeight / 2) - 2);
            Console.WriteLine("███       ███    ███   ███    █▀    ███    █▀    ███    ███ \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 30, (Console.WindowHeight / 2) - 1);
            Console.WriteLine("███       ███    ███   ███         ▄███▄▄▄      ▄███▄▄▄▄██▀ \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 30, (Console.WindowHeight / 2));
            Console.WriteLine("███       ███    ███ ▀███████████ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 30, (Console.WindowHeight / 2) + 1);
            Console.WriteLine("███       ███    ███          ███   ███    █▄  ▀███████████ \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 30, (Console.WindowHeight / 2) + 2);
            Console.WriteLine("███▌    ▄ ███    ███    ▄█    ███   ███    ███   ███    ███ \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 30, (Console.WindowHeight / 2) + 3);
            Console.WriteLine("█████▄▄██  ▀██████▀   ▄████████▀    ██████████   ███    ███ \r\n");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 30, (Console.WindowHeight / 2) + 4);
            Console.WriteLine("▀                                                ███    ███ \r\n");
        }
        public void StartScreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.SetCursorPosition(Console.WindowWidth / 2, 0);
            Console.WriteLine(" █▀▀▄          ▄▀▀█\r\n ");
            Console.SetCursorPosition(Console.WindowWidth / 2, 1);
            Console.WriteLine(" █░░░▀▄░▄▄▄▄▄░▄▀░░░█\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 2);
            Console.WriteLine(" ▀▄░░░▀░░░░░▀░░░▄▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 3);
            Console.WriteLine("   ▌░▄▄░░░▄▄░▐▀▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 4);
            Console.WriteLine("   ▐░░█▄░░░▄█░░▌▄▄▀▀▀▀█\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 5);
            Console.WriteLine("   ▌▄▄▀▀░▄░▀▀▄▄▐░░░░░░█\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 6);
            Console.WriteLine("▄▀▀▐▀▀░▄▄▄▄▄░▀▀▌▄▄▄░░░█\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 7);
            Console.WriteLine("█░░░▀▄░█░░░█░▄▀░░░░█▀▀▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 8);
            Console.WriteLine(" ▀▄░░▀░░▀▀▀░░▀░░░▄█▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 9);
            Console.WriteLine("   █░░░░░░░░░░░▄▀▄░▀▄\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 10);
            Console.WriteLine("   █░░░░░░░░░▄▀█░░█░░█\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 11);
            Console.WriteLine("   █░░░░░░░░░░░█▄█░░▄▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 12);
            Console.WriteLine("   █░░░░░░░░░░░████▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2, 13);
            Console.WriteLine("   ▀▄▄▀▀▄▄▀▀▄▄▄█▀\r\n");


            Console.Write(" ________  ___  ___  __    ________  ___  __    _______      \r\n|\\   __  \\|\\  \\|\\  \\|\\  \\ |\\   __  \\|\\  \\|\\  \\ |\\  ___ \\     \r\n\\ \\  \\|\\  \\ \\  \\ \\  \\/  /|\\ \\  \\|\\  \\ \\  \\/  /|\\ \\   __/|    \r\n \\ \\   ____\\ \\  \\ \\   ___  \\ \\  \\\\\\  \\ \\   ___  \\ \\  \\_|/__  \r\n  \\ \\  \\___|\\ \\  \\ \\  \\\\ \\  \\ \\  \\\\\\  \\ \\  \\\\ \\  \\ \\  \\_|\\ \\ \r\n   \\ \\__\\    \\ \\__\\ \\__\\\\ \\__\\ \\_______\\ \\__\\\\ \\__\\ \\_______\\\r\n    \\|__|     \\|__|\\|__| \\|__|\\|_______|\\|__| \\|__|\\|_______|");

        }
        private void LVLUPScreen()
        {
            Console.Clear();
            bool lvlup = true;
            Console.WriteLine("\r\n ██▓  ██▒   █▓ ██▓        █    ██  ██▓███  \r\n▓██▒ ▓██░   █▒▓██▒        ██  ▓██▒▓██░  ██▒\r\n▒██░  ▓██  █▒░▒██░       ▓██  ▒██░▓██░ ██▓▒\r\n▒██░   ▒██ █░░▒██░       ▓▓█  ░██░▒██▄█▓▒ ▒\r\n░██████▒▒▀█░  ░██████▒   ▒▒█████▓ ▒██▒ ░  ░\r\n░ ▒░▓  ░░ ▐░  ░ ▒░▓  ░   ░▒▓▒ ▒ ▒ ▒▓▒░ ░  ░\r\n░ ░ ▒  ░░ ░░  ░ ░ ▒  ░   ░░▒░ ░ ░ ░▒ ░     \r\n  ░ ░     ░░    ░ ░       ░░░ ░ ░ ░░       \r\n    ░  ░   ░      ░  ░      ░              \r\n          ░                                \r\n");
            ConsoleKey key = Console.ReadKey(true).Key;
            while (lvlup)
            {
                switch (key)
                {
                    case ConsoleKey.Spacebar:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        lvlup = false;
                        break;
                    default:
                        break;
                }
            }
        }
        public void MovePlayer()
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (Map.IsValidMove(Map.playerX, Map.playerY - 1))
                    {
                        Map.UpdatePlayerPos(Map.playerX, Map.playerY - 1);
                        DetectCombat();
                    }


                    break;
                case ConsoleKey.DownArrow:
                    if (Map.IsValidMove(Map.playerX, Map.playerY + 1))
                    {
                        Map.UpdatePlayerPos(Map.playerX, Map.playerY + 1);
                        DetectCombat();
                    }

                    break;
                case ConsoleKey.LeftArrow:
                    if (Map.IsValidMove(Map.playerX - 1, Map.playerY))
                    {
                        Map.UpdatePlayerPos(Map.playerX - 1, Map.playerY);
                        DetectCombat();
                    }

                    break;
                case ConsoleKey.RightArrow:
                    if (Map.IsValidMove(Map.playerX + 1, Map.playerY))
                    {
                        Map.UpdatePlayerPos(Map.playerX + 1, Map.playerY);
                        DetectCombat();
                    }

                    break;
                case ConsoleKey.X:
                    Explo = false;
                    OpenMenu = true;
                    break;
                default:
                    break;
            }
        }
        public void DetectCombat()
        {
            Random rand = new Random();

            if (Map.IsPlayerOnGrass())
            {
                switch (rand.Next(8))
                {
                    case 0:
                        StartCombat();
                        if (_win) WinScreen();
                        else LoseScreen();
                        break;
                    default:
                        break;
                }
            }
        }

        
    }
}
