using FinchAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinchControl
{
    class Screens
    {
        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        public static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        public static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }
        public static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;
            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();
            do
            {
                Screens.DisplayScreenHeader("Main Menu");

                Console.WriteLine("\t1) Connect Finch Robot");
                Console.WriteLine("\t2) Talent Show");
                //Console.WriteLine("\t3) Data Recorder");
                //Console.WriteLine("\t4) Alarm System");
                //Console.WriteLine("\t5) User Programming");
                Console.WriteLine("\t6) Disconnect Finch Robot");
                Console.WriteLine("\t7) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine();


                switch (menuChoice)
                {
                    case "1":
                        FinchConnectivity.DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "2":
                        TalentShow.TalentShowDisplayMenuScreen(finchRobot);
                        break;

                    case "6":
                        FinchConnectivity.DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "7":
                        FinchConnectivity.DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a number for the menu choice.");
                        Screens.DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }
        public static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }
        public static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        public static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }
        public static void DisplayScreenFinchConnected()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tConnection established with Finch");
            Console.WriteLine();
        }
    }
}
