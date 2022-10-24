using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SurvivalTextAdventure
{
    class Game
    {
        public void Start()
        {
            Title = "Halloween adventure of Strung High";
            RunMainMenu();


        }

        private void RunMainMenu()
        {

            string prompt = @"
                        _...---..._
                      ,'_         _`.
                     / / `.     ,' \ \
                    :  \___`._,'___/  :
           _        |  ..   /_\   ,,  |        _
          / \       :   \`-.___.-'/   :       /,\
         /,' \       \   `._____,'   /       /:  \
         |O) |        `.__..---..__.'        || ,|
      _  || .|  _   _   _  || O|  _   _   _  |' ||  _
     /,\ |'| | /.\ /;\ /,\ |' ;| /'\ /.\ /,\ | ,O| /`\
    _|_|_|___|_|_|_|_|_|_|_|_'_|_|_|_|_|_|_|_|___|_|_|_
    -=o===-.  __  -___/___\___  ,-==O==-' _ -.__ ---  _
    ___,-___-___`_|           |___.__-o__'_________-.__
     |,| | ; | ||||   HAPPY   || | | |,| |'| | ,|| |`|
     |o| | | | |'|| HALLOWEEN!|| |;| ||| |,| | |'| |;|
    _|_|_|___|_|_||___________||_|_|_|_|_|_|_|___|_|_|_
     __,--. -.__,--.  `-==O=-._  ._ ,-   -- _ --=o=-._
    ____-o_______-__-'___`_-________.___-______,-._____
     |,| |,-'| |,| |;| |o| |'-.| |,| |(| |`| |,-'| |,|          


Welcome to the 'Halloween adventure of Strung High. What would you like to do?
(Use the arrow keys to cycle through options and press enter to select an option.)";
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;

            }
        }

        private void ExitGame()
        {
            Console.WriteLine("Press any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Clear();
            Console.WriteLine("This game was created by Haider Alam.");
            Console.WriteLine("In this game you can make multiple choices which will either \nlead you to survival or to your demise.\nYou will find in it riddles, fights, math questions, and MORE.");
            Console.WriteLine("Created as a final project for the 12-Week\nCapita training.\n This project uses ASCII ART in its adventure.");
            Console.WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();

        }

        private void RunFirstChoice()
        {
            Program program = new Program();
            Program.gameTitle();

        }
    }
}
