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
        private static List<Option>? options;
        public void createMenu(Game game)
        {
            Save save= new Save();
            options = new List<Option>
            {
                new Option("Team Summary",() => openTeamSummary() ),
                new Option("Inventory", () => openInventory()),
                new Option("Save", () => openSave()),
                new Option("Exit",() => game.Map.DrawMap()),
            };
            int index = 0;

            WriteMenu(options, options[index]);

            ConsoleKey key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.DownArrow:
                    if (index + 1 < options.Count) 
                    {
                        index++;
                        WriteMenu(options, options[index]);
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (index - 1 >=0) 
                    {
                        index--;
                        WriteMenu(options, options[index]);
                    }
                    break;
                case ConsoleKey.Enter:
                    {
                        options[index].Selected.Invoke();
                        index = 0;
                    }
                    break;
                case ConsoleKey.Escape:
                    {
                        game.Explo = true;
                        game.OpenMenu = false;
                    }
                    break;
                default:
                    {
                        WriteMenu(options, options[index]);
                        break;
                    }
                    
            }
            Console.ReadKey();
        }

        public static void openTeamSummary()
        {
            TeamSummary ts = new TeamSummary();
            ts.openTeamSummary();
        }

        public static void openInventory()
        {
            Inventory In = new Inventory();
            In.openInventory();

        }

        public static void openSave()
        {
            Save save = new Save();
            save.openSaveMenu();
        }


        public static void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();
            foreach (Option option in options) 
            {
                if (option == selectedOption)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write (" ");
                }
                Console.WriteLine(option.Name);
            }
        }
    }

    public class Option
    {
        public string Name { get;}
        public Action Selected { get; }

        public Option(string name, Action selected)
        {
            Name = name;
            Selected = selected;
        }
    }

}