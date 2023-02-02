using System.Numerics;

namespace Projet_7
{
    internal class Game
    {

        private bool start = true;
        private bool _lose;
        private bool win;

        Map map = new Map();

        Pikachu pikachu = new PikachuDresseur();

        public void Run()
        {


        Start:
            StartScreen();
            // boucle de jeu
            while (true)
            {

                if (start)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.Spacebar:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            if (_lose) { StartScreen(); _lose = false; map.ResetPlayer(); }
                            else
                            {
                                start = false;
                                map.DrawMap();
                                map.UpdatePlayerPos(map.playerX, map.playerY);
                            }
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    MovePlayer();

                    if (map.IsPlayerOnGrass())
                    {
                        Random rand = new Random();
                        switch (rand.Next(8))
                        {
                            case 0:
                                StartCombat();
                                if (win) WinScreen();
                                else LoseScreen();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        public void StartCombat()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Combat c = new Combat(pikachu);
            c.Fight();
            win = c.win;
            _lose = c.lose;
            start = true;
        }
        public void WinScreen()
        {
            //Console.Clear();
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
        public void MovePlayer()
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {

                case ConsoleKey.UpArrow:
                    if (map.IsValidMove(map.playerX, map.playerY - 1))
                        map.UpdatePlayerPos(map.playerX, map.playerY - 1);
                    break;
                case ConsoleKey.DownArrow:
                    if (map.IsValidMove(map.playerX, map.playerY + 1))
                        map.UpdatePlayerPos(map.playerX, map.playerY + 1);
                    break;
                case ConsoleKey.LeftArrow:
                    if (map.IsValidMove(map.playerX - 1, map.playerY))
                        map.UpdatePlayerPos(map.playerX - 1, map.playerY);
                    break;
                case ConsoleKey.RightArrow:
                    if (map.IsValidMove(map.playerX + 1, map.playerY))
                        map.UpdatePlayerPos(map.playerX + 1, map.playerY);
                    break;
                default:
                    break;
            }
        }
    }
}
