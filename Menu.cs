using System;
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
        public void createMenu(Map map)
        {
            TeamSummary ts = new TeamSummary();
            Inventory inv = new Inventory();
            Save save= new Save();
            options = new List<Option>
            {
                new Option("Team Summary",() => ts.openTeamSummary() ),
                new Option("Inventory", () => inv.openInventory()),
                new Option("Save", () => save.openSaveMenu()),
                new Option("Exit",() => map.DrawMap()),
            };
            int index = 0;

            WriteMenu(options, options[index]);

            ConsoleKey key = Console.ReadKey(true).Key;
            do
            {
                if (key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options.Count)
                    {
                        index++;
                        WriteMenu(options, options[index]);
                    }
                }
                if (key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(options, options[index]);
                    }
                }
                if (key == ConsoleKey.Enter)
                {
                    options[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (key != ConsoleKey.Escape);
            Console.ReadKey();
        }



        public void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();
            foreach (Option option in options) 
            {
                if (option == selectedOption)
                {
                    Console.WriteLine("> ");
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