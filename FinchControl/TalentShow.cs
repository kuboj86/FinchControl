using FinchAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinchControl
{
    class TalentShow
    {
        public static void TalentShowDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                Screens.DisplayScreenHeader("Talent Show Menu");

                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) ");
                Console.WriteLine("\tc) ");
                Console.WriteLine("\td) ");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound(finchRobot);
                        break;

                    case "b":

                        break;

                    case "c":

                        break;

                    case "d":

                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        Screens.DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        public static void TalentShowDisplayLightAndSound(Finch finchRobot)
        {
            Console.CursorVisible = false;

            Screens.DisplayScreenHeader("Light and Sound");

            
            Console.WriteLine("\tThe Finch robot will now show off its glowing talents!");
            Screens.DisplayContinuePrompt();

            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(1396); //F
            finchRobot.wait(220); 
            finchRobot.noteOn(1479);//F#
            finchRobot.wait(220);
            finchRobot.setLED(0, 0, 0);

            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(1567); // G
            finchRobot.wait(330);
            finchRobot.noteOn(1661); //G#
            finchRobot.wait(330);
            finchRobot.setLED(0, 0, 0);

            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(1760); // A
            finchRobot.wait(330);
            finchRobot.noteOn(2093); // C HIGH NOTE
            finchRobot.wait(330);
            finchRobot.setLED(0, 0, 0);

            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(1975); // B
            finchRobot.wait(165);
            finchRobot.noteOn(2093); // C
            finchRobot.wait(165);
            finchRobot.noteOn(1975); // B
            finchRobot.wait(165);
            finchRobot.noteOn(1864); // A#
            finchRobot.wait(330);
            finchRobot.setLED(0, 0, 0);

            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(1760); // A
            finchRobot.wait(330);
            finchRobot.noteOn(1661); // G#
            finchRobot.wait(330);
            finchRobot.setLED(0, 0, 0);

            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(1567); // G HOLD
            finchRobot.wait(330);
            finchRobot.noteOn(1479);//F#
            finchRobot.wait(165);
            finchRobot.setLED(0, 0, 0);

            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(1396); //F
            finchRobot.wait(330);
            finchRobot.noteOff();
            finchRobot.noteOn(1396); //F
            finchRobot.wait(330);
            finchRobot.noteOff();
            finchRobot.noteOn(1396); //F
            finchRobot.wait(659);
            finchRobot.noteOff();
            finchRobot.setLED(0, 0, 0);


            finchRobot.noteOff();
            Program.DisplayMenuPrompt("Talent Show Menu");
        }
    }
}
