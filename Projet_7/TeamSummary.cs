using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_7
{
    public  class TeamSummary : Pikachu
    {
        public TeamSummary() { }

        public void openTeamSummary()
        {
            Pikachu pikachu = new Pikachu();
            Console.Clear();
            Console.SetCursorPosition(25, 0);
            Console.WriteLine("________  ___  ___  __    ________          ________  ___  ___  _____ ______   _____ ______   ________  ________      ___    ___ \r\n");
            Console.SetCursorPosition(25, 1);
            Console.WriteLine("|\\   __  \\|\\  \\|\\  \\|\\  \\ |\\   __  \\        |\\   ____\\|\\  \\|\\  \\|\\   _ \\  _   \\|\\   _ \\  _   \\|\\   __  \\|\\   __  \\    |\\  \\  /  /|\r\n");
            Console.SetCursorPosition(25, 2);
            Console.WriteLine("\\ \\  \\|\\  \\ \\  \\ \\  \\/  /|\\ \\  \\|\\  \\       \\ \\  \\___|\\ \\  \\\\\\  \\ \\  \\\\\\__\\ \\  \\ \\  \\\\\\__\\ \\  \\ \\  \\|\\  \\ \\  \\|\\  \\   \\ \\  \\/  / /\r\n");
            Console.SetCursorPosition(25, 3);
            Console.WriteLine(" \\ \\   ____\\ \\  \\ \\   ___  \\ \\   __  \\       \\ \\_____  \\ \\  \\\\\\  \\ \\  \\\\|__| \\  \\ \\  \\\\|__| \\  \\ \\   __  \\ \\   _  _\\   \\ \\    / / \r\n");
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("  \\ \\  \\___|\\ \\  \\ \\  \\\\ \\  \\ \\  \\ \\  \\       \\|____|\\  \\ \\  \\\\\\  \\ \\  \\    \\ \\  \\ \\  \\    \\ \\  \\ \\  \\ \\  \\ \\  \\\\  \\|   \\/  /  /  \r\n");
            Console.SetCursorPosition(25, 5);
            Console.WriteLine("   \\ \\__\\    \\ \\__\\ \\__\\\\ \\__\\ \\__\\ \\__\\        ____\\_\\  \\ \\_______\\ \\__\\    \\ \\__\\ \\__\\    \\ \\__\\ \\__\\ \\__\\ \\__\\\\ _\\ __/  / /    \r\n");
            Console.SetCursorPosition(25, 6);
            Console.WriteLine("    \\|__|     \\|__|\\|__| \\|__|\\|__|\\|__|       |\\_________\\|_______|\\|__|     \\|__|\\|__|     \\|__|\\|__|\\|__|\\|__|\\|__|\\___/ /     \r\n");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("                                               \\|_________|                                                          \\|___|/      \r\n");
            WriteMenu(pikachu);
        }

        public void WriteMenu(Pokemon IneedaHero)
        {
            Console.WriteLine("===============================================================================================================================================");
            for (int iterator = 0; iterator < 30 ; iterator++)
            {
                switch (iterator)
                {
                case 0:
                    WriteCapacity(Name.ToString());
                    break;
                case 5:
                    WriteCapacity(LVL.ToString());
                    break;
                case 9:
                    WriteCapacity(XP.ToString());
                    break;
                default:
            Console.WriteLine("PIKA PIKA");
                break;
                }
            }
            Console.WriteLine("===============================================================================================================================================");
        }
        public void WriteCapacity(string statistic)
        {
            for (int iterator = 0; iterator < 90 - statistic.Length; iterator++)
            {
                switch (iterator)
                {
                    case 0:
                        Console.Write("|");
                        break;
                    case (87):
                        Console.Write("|\r\n");
                        break;
                    case (44):
                        Console.Write(statistic);
                        break;
                    default:
                        Console.Write(" ");
                        break;
                }

            }
        }
    }
}