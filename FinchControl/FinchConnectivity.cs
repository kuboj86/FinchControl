using FinchAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinchControl
{
    class FinchConnectivity
    {
        public static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            Screens.DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            Screens.DisplayContinuePrompt();


            //This will not work currently because this app was built in .NET Core
            finchRobot.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnected.");

            Program.DisplayMenuPrompt("Main Menu");
        }
        public static void DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected = false;

            Screens.DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            Screens.DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            if (robotConnected == true)
            {
                Screens.DisplayScreenFinchConnected();
                FinchConnectedStartup(finchRobot);
            }

            Program.DisplayMenuPrompt("Main Menu");

        }

        public static Finch FinchConnectedStartup(Finch finchRobot)
        {
            finchRobot.setMotors(-100, 100);
            finchRobot.wait(300);
            finchRobot.setMotors(100, -100);
            finchRobot.wait(300);
            finchRobot.setMotors(0, 0);
            for (int i = 0; i < 3; i++)
            {

                finchRobot.setLED(0, 255, 0);
                finchRobot.wait(500);
                finchRobot.setLED(0, 0, 0);

                finchRobot.noteOn(i);
                finchRobot.wait(500);
                finchRobot.noteOff();

            }


            finchRobot.setLED(0, 255, 0);
            return finchRobot;
        }
    }
}
