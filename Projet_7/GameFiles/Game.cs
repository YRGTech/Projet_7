using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;
using System.Text.Json;
using Projet_7.GameFiles.MapFiles;
using Projet_7.GameFiles.SaveFiles;
using Projet_7.GameFiles.MenuFiles.InventoryFiles.ItemsFiles;
using Projet_7.GameFiles;
using Projet_7.GameFiles.MenuFiles.InventoryFiles;
using Projet_7.GameFiles.MenuFiles;
using Projet_7.GameFiles.PokemonsFiles;

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
        public PikachuDresseur? Pikachu { get; set; }
        public Potion? Potionnette { get; set; }
        public Potion? Potion { get; set; }
        public Potion? MaximaPocion { get; set; }
        public Bouf? Boeuf { get; set; }
        public Bouf? Tortoise { get; set; }
        public Bouf? Mage { get; set; }

        public Debouf? Pangolin { get; set; }
        public Debouf? Bat { get; set; }
        public bool LootItem { get; private set; }

        public Game()
        {

            Map = new Map();
            SerializeTheObject loadSave;
            string loadString;
            loadString = File.ReadAllText("GameFiles/SaveFiles/save.json");
            loadSave = JsonSerializer.Deserialize<SerializeTheObject>(loadString);
            Pikachu = loadSave.Pika;
            Map.playerX = loadSave.PosX;
            Map.playerY = loadSave.PosY;
            Potionnette = new Potion("Potionnette", loadSave.Potionnette, "ça régène un peu de PV mais pas bcp", 20);
            Potion = new Potion("potion", loadSave.Potion, "ça régène des PV", 50);
            MaximaPocion = new Potion("MaximaPocion", loadSave.MaximaPocion, "ça régène bcp wallah", 80);
            Mage = new Bouf("Mage", loadSave.Mage, "Manger un mage vous fait regagner des PM", 40);
            Tortoise = new Bouf("Tortoise", loadSave.Tortoise, "Manger une tortue vous augmente votre défense", 20);
            Boeuf = new Bouf("Boeuf", loadSave.Boeuf, "Manger un boeuf vous augmente votre attaque", 20);
            Pangolin = new Debouf("Pangolin", loadSave.Pangolin, "Vous donnez un pangolain à manger à votre ennemi,\n                              il attrape le variant Delta du covid19, sa défense baisse", 20, 3);
            Bat = new Debouf("Bat", loadSave.Bat, "Vous donnez une chauve-souris à manger à votre ennemi,\n                              il attrape le variant Alpha du covid19, son attaque baisse", 20, 3);
            Inventory.NewInventory(0, 5, 5, 0, Potionnette, Potion, MaximaPocion, Boeuf, Mage, Tortoise, Pangolin, Bat, Pikachu);
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
                            if (_lose) { StartScreen(); _lose = false; Map = new Map(); Pikachu = new PikachuDresseur(); }
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

            Console.SetCursorPosition(Console.WindowWidth / 2 - 24, 0);
            Console.WriteLine("________  ___  ___  __    ________  ___  __    _______      \r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, 1);
            Console.WriteLine("|\\   __  \\|\\  \\|\\  \\|\\  \\ |\\   __  \\|\\  \\|\\  \\ |\\  ___ \\     \r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, 2);
            Console.WriteLine("\\ \\  \\|\\  \\ \\  \\ \\  \\/  /|\\ \\  \\|\\  \\ \\  \\/  /|\\ \\   __/|    \r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, 3);
            Console.WriteLine(" \\ \\   ____\\ \\  \\ \\   ___  \\ \\  \\\\\\  \\ \\   ___  \\ \\  \\_|/__  \r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, 4);
            Console.WriteLine("  \\ \\  \\___|\\ \\  \\ \\  \\\\ \\  \\ \\  \\\\\\  \\ \\  \\\\ \\  \\ \\  \\_|\\ \\ \r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, 5);
            Console.WriteLine("   \\ \\__\\    \\ \\__\\ \\__\\\\ \\__\\ \\_______\\ \\__\\\\ \\__\\ \\_______\\\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, 6);
            Console.WriteLine("    \\|__|     \\|__|\\|__| \\|__|\\|_______|\\|__| \\|__|\\|_______|\r\n");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 18);
            Console.WriteLine(" █▀▀▄          ▄▀▀█\r\n ");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 19);
            Console.WriteLine(" █░░░▀▄░▄▄▄▄▄░▄▀░░░█\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 20);
            Console.WriteLine(" ▀▄░░░▀░░░░░▀░░░▄▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 21);
            Console.WriteLine("   ▌░▄▄░░░▄▄░▐▀▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 22);
            Console.WriteLine("   ▐░░█▄░░░▄█░░▌▄▄▀▀▀▀█\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 23);
            Console.WriteLine("   ▌▄▄▀▀░▄░▀▀▄▄▐░░░░░░█\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 24);
            Console.WriteLine("▄▀▀▐▀▀░▄▄▄▄▄░▀▀▌▄▄▄░░░█\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 25);
            Console.WriteLine("█░░░▀▄░█░░░█░▄▀░░░░█▀▀▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 26);
            Console.WriteLine(" ▀▄░░▀░░▀▀▀░░▀░░░▄█▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 27);
            Console.WriteLine("   █░░░░░░░░░░░▄▀▄░▀▄\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 28);
            Console.WriteLine("   █░░░░░░░░░▄▀█░░█░░█\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 29);
            Console.WriteLine("   █░░░░░░░░░░░█▄█░░▄▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 30);
            Console.WriteLine("   █░░░░░░░░░░░████▀\r\n");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 31);
            Console.WriteLine("   ▀▄▄▀▀▄▄▀▀▄▄▄█▀\r\n");

        }
        private void LVLUPScreen()
        {
            Console.Clear();
            bool lvlup = true;
            Console.WriteLine("\r\n ██▓  ██▒   █▓ ██▓        █    ██  ██▓███  \r\n▓██▒ ▓██░   █▒▓██▒        ██  ▓██▒▓██░  ██▒\r\n▒██░  ▓██  █▒░▒██░       ▓██  ▒██░▓██░ ██▓▒\r\n▒██░   ▒██ █░░▒██░       ▓▓█  ░██░▒██▄█▓▒ ▒\r\n░██████▒▒▀█░  ░██████▒   ▒▒█████▓ ▒██▒ ░  ░\r\n░ ▒░▓  ░░ ▐░  ░ ▒░▓  ░   ░▒▓▒ ▒ ▒ ▒▓▒░ ░  ░\r\n░ ░ ▒  ░░ ░░  ░ ░ ▒  ░   ░░▒░ ░ ░ ░▒ ░     \r\n  ░ ░     ░░    ░ ░       ░░░ ░ ░ ░░       \r\n    ░  ░   ░      ░  ░      ░              \r\n          ░                                \r\n");
            while (lvlup)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
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
                        DetectItem();
                    }


                    break;
                case ConsoleKey.DownArrow:
                    if (Map.IsValidMove(Map.playerX, Map.playerY + 1))
                    {
                        Map.UpdatePlayerPos(Map.playerX, Map.playerY + 1);
                        DetectItem();
                        DetectCombat();
                    }

                    break;
                case ConsoleKey.LeftArrow:
                    if (Map.IsValidMove(Map.playerX - 1, Map.playerY))
                    {
                        Map.UpdatePlayerPos(Map.playerX - 1, Map.playerY);
                        DetectItem();
                        DetectCombat();
                    }

                    break;
                case ConsoleKey.RightArrow:
                    if (Map.IsValidMove(Map.playerX + 1, Map.playerY))
                    {
                        Map.UpdatePlayerPos(Map.playerX + 1, Map.playerY);
                        DetectItem();
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
        public void DetectItem()
        {
            Items items = RandItem();
            if (Map.IsPlayerOnItem())
            {
                switch (items)
                {
                    case Items.Potionnette:
                        Inventory.Potionnette.Amount++;
                        break;
                    case Items.Potion:
                        Inventory.Potion.Amount++;
                        break;
                    case Items.MaximaPocion:
                        Inventory.MaximaPocion.Amount++;
                        break;
                    case Items.Boeuf:
                        Inventory.Boeuf.Amount++;
                        break;
                    case Items.Tortoise:
                        Inventory.Tortoise.Amount++;
                        break;
                    case Items.Mage:
                        Inventory.Mage.Amount++;
                        break;
                    case Items.Pangolin:
                        Inventory.Pangolin.Amount++;
                        break;
                    case Items.Bat:
                        Inventory.Bat.Amount++;
                        break;
                    default:
                        break;
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, 1);
                Console.WriteLine("You have found a {0} !", items);
                Thread.Sleep(1000);
                Map.DrawLineMap(1);
            }
        }

        private Items RandItem()
        {
            Random rand = new Random();
            switch (rand.Next(8))
            {
                case 0:
                    return Items.Bat;
                case 1:
                    return Items.Potion;
                case 2:
                    return Items.MaximaPocion;
                case 3:
                    return Items.Boeuf;
                case 4:
                    return Items.Tortoise;
                case 5:
                    return Items.Mage;
                case 6:
                    return Items.Pangolin;
                default:
                    return Items.Potionnette;
            }
        }
    }
}
