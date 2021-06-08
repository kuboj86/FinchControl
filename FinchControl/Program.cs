using FinchAPI;
using System;

namespace FinchControl
{
    // **************************************************
    //
    // Title: Finch Control - Menu Starter
    // Description: Starter solution with the helper methods,
    //              opening and closing screens, and the menu
    // Application Type: Console
    // Author: Jason Kubo
    // Dated Created: 1/22/2020
    // Last Modified: 6/8/2021
    //
    // **************************************************

    class Program
    {
        static void Main(string[] args)
        {
            Screens.SetTheme();

            Screens.DisplayWelcomeScreen();
            Screens.DisplayMenuScreen();
            Screens.DisplayClosingScreen();
        }
        public static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }
    }
}
