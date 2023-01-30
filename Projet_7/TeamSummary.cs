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
            Console.WriteLine(" _________  _______   ________  _____ ______           ________  ___  ___  _____ ______   _____ ______   ________  ________      ___    ___ \r\n");
            Console.SetCursorPosition(25, 1);
            Console.WriteLine("|\\___   ___\\\\  ___ \\ |\\   __  \\|\\   _ \\  _   \\        |\\   ____\\|\\  \\|\\  \\|\\   _ \\  _   \\|\\   _ \\  _   \\|\\   __  \\|\\   __  \\    |\\  \\  /  /|\r\n");
            Console.SetCursorPosition(25, 2);
            Console.WriteLine("\\|___ \\  \\_\\ \\   __/|\\ \\  \\|\\  \\ \\  \\\\\\__\\ \\  \\       \\ \\  \\___|\\ \\  \\\\\\  \\ \\  \\\\\\__\\ \\  \\ \\  \\\\\\__\\ \\  \\ \\  \\|\\  \\ \\  \\|\\  \\   \\ \\  \\/  / /\r\n");
            Console.SetCursorPosition(30, 3);
            Console.WriteLine("\\ \\  \\ \\ \\  \\_|/_\\ \\   __  \\ \\  \\\\|__| \\  \\       \\ \\_____  \\ \\  \\\\\\  \\ \\  \\\\|__| \\  \\ \\  \\\\|__| \\  \\ \\   __  \\ \\   _  _\\   \\ \\    / / \r\n");
            Console.SetCursorPosition(31, 4);
            Console.WriteLine("\\ \\  \\ \\ \\  \\_|\\ \\ \\  \\ \\  \\ \\  \\    \\ \\  \\       \\|____|\\  \\ \\  \\\\\\  \\ \\  \\    \\ \\  \\ \\  \\    \\ \\  \\ \\  \\ \\  \\ \\  \\\\  \\|   \\/  /  /  \r\n");
            Console.SetCursorPosition(32, 5);
            Console.WriteLine("\\ \\__\\ \\ \\_______\\ \\__\\ \\__\\ \\__\\    \\ \\__\\        ____\\_\\  \\ \\_______\\ \\__\\    \\ \\__\\ \\__\\    \\ \\__\\ \\__\\ \\__\\ \\__\\\\ _\\ __/  / /    \r\n");
            Console.SetCursorPosition(33, 6);
            Console.WriteLine("\\|__|  \\|_______|\\|__|\\|__|\\|__|     \\|__|       |\\_________\\|_______|\\|__|     \\|__|\\|__|     \\|__|\\|__|\\|__|\\|__|\\|__|\\___/ /     \r\n");
            Console.SetCursorPosition(82, 7);
            Console.WriteLine("\\|_________|                                                          \\|___|/      \r\n");
            Console.WriteLine("===============================================================================================================================================");
            Console.WriteLine("|                  {0}                                             |                                                                          |", pikachu.Name);
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("|                                                                  |                                                                          |");
            Console.WriteLine("===============================================================================================================================================");

        }

        public void WriteMenu(string Stats)
        {
        }
    }
}