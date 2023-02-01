using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_7
{
    public  class TeamSummary : Pikachu
    {
        private int _id = 0;
        public TeamSummary() { }

        public void openTeamSummary(Game game)
        {
            bool _teamSummaryOpened = true;
            Pikachu pikachu = new Pikachu();
            Console.Clear();
            writeTitle();
            WriteMenu(pikachu);
            writePikachu();
            while (_teamSummaryOpened)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.Escape:
                        Menu menu = new Menu();
                        Console.Clear();
                        menu.createMenu(game);
                        _teamSummaryOpened = false;
                        break;
                }
            }
        }

        public void WriteMenu(Pokemon IneedaHero)
        {
            int XPneeded = IneedaHero.XPMax - IneedaHero.XP;
            Console.WriteLine("===============================================================================================================================================");
            for (int iterator = 0; iterator < 29 ; iterator++)
            {
                switch (iterator)
                {
                case 0:
                    WriteCapacity("Name :",IneedaHero.Name.ToString());
                    break;
                case 1:
                    WriteCapacity("Type :", IneedaHero.TYPE.ToString());
                    break;
                case 5:
                    WriteCapacity("Level :", IneedaHero.LVL.ToString());
                    break;
                case 6:
                    WriteCapacity("Experience :", IneedaHero.XP.ToString());
                    break;
                case 7:
                    WriteCapacity("Before Next Level :", XPneeded.ToString());
                    break;
                case 13:
                    WritePVPM("PV :", PV.ToString(), IneedaHero.PVMax.ToString());
                    break;
                case 14:
                    WritePVPM("PM :", PM.ToString(), IneedaHero.PMMax.ToString());
                    break;
                case 15:
                    WriteCapacity("Attack :", IneedaHero.ATK.ToString());
                    break;
                case 16:
                    WriteCapacity("Defense :", IneedaHero.DEF.ToString());
                break;
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("===============================================================================================================================================");
            WriteEdgeBorder();
        }
        public void WriteCapacity(string statshown, string statistic)
        {
            Console.SetCursorPosition(68, 12 + _id);
            Console.Write(statshown);
            Console.Write("{0} \n",statistic);
            if (_id == 1)
            {
                _id += 4;
            }
            else if (_id == 7)
            {
                _id += 4;
            }
            else
            {
                _id++;
            }
        }
        public void WritePVPM(string statshown, string statistic, string statistic_max)
        {
            Console.SetCursorPosition(68, 12 + _id);
            Console.Write(statshown);
            Console.Write("{0}/{1}", statistic, statistic_max);
            _id++;
        }
        public void WriteEdgeBorder()
        {
            for (int iterator = 0; iterator < 30; iterator++)
            {
                Console.SetCursorPosition(0, 10 + iterator);
                Console.Write("|");
            }
            for (int iterator2 =0; iterator2 < 30; iterator2++)
            {
                Console.SetCursorPosition(142, 10 + iterator2);
                Console.Write("|");
            }
        }

        public void writePikachu()
        {
            Console.SetCursorPosition(155, 16);
            Console.WriteLine("░█▀▀▄░░░░░░░░░░░▄▀▀█ \r\n");
            Console.SetCursorPosition(155, 17);
            Console.WriteLine("░█░░░▀▄░▄▄▄▄▄░▄▀░░░█\r\n");
            Console.SetCursorPosition(155, 18);
            Console.WriteLine("░░▀▄░░░▀░░░░░▀░░░▄▀ \r\n");
            Console.SetCursorPosition(155, 19);
            Console.WriteLine("░░░░▌░▄▄░░░▄▄░▐▀▀ \r\n");
            Console.SetCursorPosition(155, 20);
            Console.WriteLine("░░░▐░░█▄░░░▄█░░▌▄▄▀▀▀▀█\r\n");
            Console.SetCursorPosition(155, 21);
            Console.WriteLine("░░░▌▄▄▀▀░▄░▀▀▄▄▐░░░░░░█ \r\n");
            Console.SetCursorPosition(155, 22);
            Console.WriteLine("▄▀▀▐▀▀░▄▄▄▄▄░▀▀▌▄▄▄░░░█ \r\n");
            Console.SetCursorPosition(155, 23);
            Console.WriteLine("█░░░▀▄░█░░░█░▄▀░░░░█▀▀▀ \r\n");
            Console.SetCursorPosition(155, 24);
            Console.WriteLine("░▀▄░░▀░░▀▀▀░░▀░░░▄█▀ \r\n");
            Console.SetCursorPosition(155, 25);
            Console.WriteLine("░░░█░░░░░░░░░░░▄▀▄░▀▄ \r\n");
            Console.SetCursorPosition(155, 26);
            Console.WriteLine("░░░█░░░░░░░░░▄▀█░░█░░█ \r\n");
            Console.SetCursorPosition(155, 27);
            Console.WriteLine("░░░█░░░░░░░░░░░█▄█░░▄▀ \r\n");
            Console.SetCursorPosition(155, 28);
            Console.WriteLine("░░░█░░░░░░░░░░░████▀ \r\n");
            Console.SetCursorPosition(155, 29);
            Console.WriteLine("░░░▀▄▄▀▀▄▄▀▀▄▄▄█▀ \r\n");
        }
        public void writeTitle()
        {
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
        }
    }
}