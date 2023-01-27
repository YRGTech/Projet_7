using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projet_7
{
    internal static class ConsoleManager
    {
        [DllImport("user32.dll")]
        private static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        /// <summary>
        /// Disable resizing, minimize and maximize buttons.
        /// Change console properties.
        /// </summary>
        public static void WindowSetup()
        {
            //Disable resizing and minimize/maximize buttons
            IntPtr window = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(window, false);
            int MF_BYCOMMAND = 0x00000000;
            int SC_MINIMIZE = 0xF020;
            int SC_MAXIMIZE = 0xF030;
            int SC_SIZE = 0xF000;
            DeleteMenu(sysMenu, SC_MINIMIZE, MF_BYCOMMAND);
            DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
            DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);

            //Set console properties
            Console.Title = "Pikoke";
            Console.TreatControlCAsInput = true;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            //Set console size to 80% of the largest possible size
            int width = (int)(Console.LargestWindowWidth * 0.8);
            int height = (int)(Console.LargestWindowHeight * 0.8);
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
        }
    }
}
