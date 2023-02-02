using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Linq;

namespace Projet_7
{
    public class Menu
    {
        private static List<Option>? _options;
        private static Game _game;
        public void CreateMenu(Game game)
        {
            _options = new List<Option>
            {
                new Option("Team Summary",() => OpenTeamSummary(game) ),
                new Option("Inventory", () => OpenInventory()),
                new Option("Save", () => OpenSave(game, game.Inventory)),
                new Option("Resume Game", () => ReturnGame()),
                new Option("Exit",() => Environment.Exit(0)),
            };
            int index = 0;
            _game = game;
            WriteMenu(_options, _options[index]);

            while (game.OpenMenu == true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        if (index + 1 < _options.Count)
                        {
                            index++;
                            WriteMenu(_options, _options[index]);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (index - 1 >= 0)
                        {
                            index--;
                            WriteMenu(_options, _options[index]);
                        }
                        break;
                    case ConsoleKey.Enter:
                        {
                            _options[index].Selected.Invoke();
                            index = 0;
                        }
                        break;
                    case ConsoleKey.Escape:
                        {
                            ReturnGame();
                        }
                        break;
                    default:
                        {
                            WriteMenu(_options, _options[index]);
                            break;
                        }

                }
            }
        }

        public static void OpenTeamSummary(Game game)
        {
            TeamSummary ts = new TeamSummary();
            ts.OpenTeamSummary(game);
        }

        public static void OpenInventory()
        {

            //inventory.Draw();

        }

        public static void OpenSave(Game game, Inventory inventory)
        {
            Save save = new Save();
            save.openSaveMenu(game, inventory);

        }

        public static void ReturnGame()
        {
            _game.OpenMenu = false;
            _game.Explo = true;
            //Console.Clear();
            _game.Map.DrawMap();
            _game.Map.UpdatePlayerPos(_game.Map.playerX, _game.Map.playerY);

        }
        public static void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            int temp = 0;
            Console.Clear();
            Console.SetCursorPosition(65, 0);
            Console.WriteLine(" _____ ______   _______   ________   ___  ___ \r\n");
            Console.SetCursorPosition(65, 1);
            Console.WriteLine("|\\   _ \\  _   \\|\\  ___ \\ |\\   ___  \\|\\  \\|\\  \\    \r\n");
            Console.SetCursorPosition(65, 2);
            Console.WriteLine("\\ \\  \\\\\\__\\ \\  \\ \\   __/|\\ \\  \\\\ \\  \\ \\  \\\\\\  \\   \r\n");
            Console.SetCursorPosition(65, 3);
            Console.WriteLine(" \\ \\  \\\\|__| \\  \\ \\  \\_|/_\\ \\  \\\\ \\  \\ \\  \\\\\\  \\  \r\n");
            Console.SetCursorPosition(65, 4);
            Console.WriteLine("  \\ \\  \\    \\ \\  \\ \\  \\_|\\ \\ \\  \\\\ \\  \\ \\  \\\\\\  \\ \r\n");
            Console.SetCursorPosition(65, 5);
            Console.WriteLine("   \\ \\__\\    \\ \\__\\ \\_______\\ \\__\\\\ \\__\\ \\_______\\ \r\n");
            Console.SetCursorPosition(65, 6);
            Console.WriteLine("    \\|__|     \\|__|\\|_______|\\|__| \\|__|\\|_______|\r\n");
            foreach (Option option in options)
            {
                if (option == selectedOption)
                {
                    Console.SetCursorPosition(84, 20 + temp);
                    Console.Write("-> ");
                    temp += 1;
                }
                else
                {
                    Console.SetCursorPosition(86, 20 + temp);
                    Console.Write(" ");
                    temp += 1;
                }
                Console.WriteLine(option.Name);
            }
        }
    }


}