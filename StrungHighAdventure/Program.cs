using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SurvivalTextAdventure
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Game constructorClass = new Game();
            constructorClass.Start();
            gameTitle();


        }

        private static string passingString = "";
        private static int score1 = score1++;



        public static void gameTitle()
        {

            Console.Clear();
            Console.WriteLine("What is your name?: ");
            string name = Console.ReadLine();
            Program.passingString = name;
            Console.Clear();
            Console.WriteLine($"Hello {name}, Welcome to the 'Halloween adventure of Strung High'.");

            Console.WriteLine("Are you sure you have what it takes to survive?");
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Press 'Enter' if you dare.");
            Console.WriteLine("-------------------------");

            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            Console.Clear();
            string choice;
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("You wake up. Slowly you begin to realise that you \nare somewehere unknown.");
            Console.WriteLine("Dazzled and confused, you analyse your surroundings. ");
            Console.WriteLine("It seems... you have been transported to, perhaps");
            Console.WriteLine("a school? But how did you get here? The last thing you remember is glimpses of red.");
            Console.WriteLine("You're on the second floor, and see a dim light at the end of a long dark hallway");
            Console.WriteLine("and on the other side of the hall, a cRackED window just slightly open.");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Walk towards the light at the end of the hallway.");
            Console.WriteLine("2. Check out the cracked window.");
            Console.WriteLine("3. Go back to sleep?");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "walk":
                    {
                        score1++;
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.WriteLine("Walking towards the dim light you are slowly regaining consciousness.");
                        Console.WriteLine("You begin to recognise the building. It's your old highschool. ");
                        Console.WriteLine("A dark, damp and abandoned environment with no life and an eerie wind.");
                        Console.WriteLine("The famous 'Strung Tight' highschool.\n The realisation causes chills down your spine...");
                        Console.WriteLine("You move slowly with caution, as you remember\n the horrors that took place here in the year 1999.");
                        Console.WriteLine("Coming closer to the light you have reached the end of\n the hall and are at the staircase.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.WriteLine("---------------------------------------------------------------------");

                        Console.ReadLine();

                        second();
                        break;
                    }
                case "2":
                case "check":
                    {
                        score1++;
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.WriteLine("Coming closer to the window, you begin to recognise the building. ");
                        Console.WriteLine("It's your old highschool. The famous 'Strung Tight' highschool.\n The realisation causes chills down your spine...");
                        Console.WriteLine("You move slowly with caution, as you begin to remember \n the horrors that took place here in the year 1999.");
                        Console.WriteLine(" ");
                        Console.WriteLine("The window shuts suddenly! Perhaps it was a gust of wind.");
                        Console.WriteLine("Or maybe something else... In any case you cannot manage to re-open it.");
                        Console.WriteLine("Outside the window is complete darkness. No help is available.");
                        Console.WriteLine("You reluctantly travel to the dim light at the end of the hall.");
                        Console.WriteLine("Press 'Enter' to continue to the staircase.");
                        Console.WriteLine("---------------------------------------------------------------------");

                        Console.ReadLine();
                        second();
                        break;
                    }

                case "3":
                case "sleep":
                    {
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.WriteLine($"{passingString} decides to go back to sleep, hoping it was just a dream");
                        Console.WriteLine($"As {passingString} tries to sleep again, he suffers sleep paralysis.\n Not being able to move his breathing becomes heavy...");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.ReadLine();
                        gameOver1();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }

        }

        public static void second()
        {

            Random rnd = new Random();
            string[] secOptions = {"Walking down the stairs you feel a cold breeze move through you, you get scared.",
            "Walking down the stairs you see a dark shadowy figure run past you, was it just a figment of your imagination?",
            "As you're walking down the stairs the school bell suddenly rings!",
            "You remember these stairs, now they drip with blood."};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(secText);
            Console.WriteLine("Being frightened you make a choice: ");
            Console.WriteLine("1. Run quickly down the stairs!");
            Console.WriteLine("2. Walk normal as you were before.");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "1" || secChoice == "run")
            {
                Console.Clear();
                score1--;
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("You begin to run and panic, moving too fast you trip over yourself.");
                Console.WriteLine("You fall and hit your head on the step, dying instantly!");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.ReadLine();
                gameOver();
            }
            else if (secChoice == "2" || secChoice == "walk")
            {
                score1++;
                third();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("I dont understand that command...");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                second();
            }
        }



        public static void third()
        {

            int year;

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("You finally reach the main hall on the first floor.");
            Console.WriteLine("You have a strange urge to go straight to your locker.\n You feel you can find answer's there.");
            Console.WriteLine($"After {passingString} arrives at their locker they try and remember that the combination");
            Console.WriteLine("was the year the 'incident' took place.");
            Console.Write("What was the year?: ");
            int.TryParse(Console.ReadLine(), out year);
            Console.WriteLine("---------------------------------------------------------------------");

            if (year == 1999)
            {
                Console.Clear();
                score1++;
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Correct answer. You've been paying attention.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                fourth();
                Console.WriteLine("---------------------------------------------------------------------");
            }
            else if (year != 1999)
            {
                score1--;
                Console.Clear();
                Console.WriteLine("Incorrect answer");
                Console.WriteLine("Try again.");
                third();
            }

        }

        public static void fourth()
        {
            Console.Clear();
            Random rnd = new Random();
            Console.WriteLine($"The locker creeks open and {passingString} finds a blood-stained note which falls to the ground.");
            Console.WriteLine("ITS A RIDDLE! but who placed it here... you must find answers.");
            Console.WriteLine("The note with the riddle reads.");
            string[] secOptions = {"''I cast spells in the dark night, my crooked nose is bent right, I am the HORROR of 'Strung Tight'... What am I?''", //witch
            "''I am a spirit of FEAR, I am see through and clear, I haunt 'Strung Tight' every year... What am I?'' ", // Ghost
            "''I am dead and I am alive, I don't age and hate sunshine, I take blood with my canines... What am I?.. "}; // vampire
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("What is the answer to the riddle?: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "witch" || secChoice == "a witch" || secChoice == "Witch")
            {
                score1++;
                Console.WriteLine(@"
                                      __,,,
                                 _.--'    /
                              .-'        /
                            .'          |
                          .'           /
                         /_____________|
                       /`~~~~~~~~~~~~~~/
                     /`               /
      ____,....----'/_________________|---....,___
,--""`             `~~~~~~~~~~~~~~~~~~`           `""--,
`'----------------.----,------------------------,-------'`
               _,'.--. \                         \
             .'  (o   ) \                        |
            c   , '--'  |                        /
           /    )'-.    \                       /
          |  .-;        \                       |
          \_/  |___,'    |                    .-'
         .---.___|_      |                   /
        (          `     |               .--'
         '.         __,-'\             .'
           `'-----'`      \        __.'
                           `-..--'`
");
                Console.WriteLine("YES! You remember now the witch. She was the math teacher at 'Strung High'. Ms. McAlgebra");
                Console.WriteLine("Her classroom was Room 69, she must be behind this.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                witch();
            }
            else if (secChoice == "ghost" || secChoice == "a ghost" || secChoice == "Ghost")
            {
                score1++;
                Console.WriteLine(@"
            .--,
           /  (
          /    \
         /      \ 
        /  0  0  \
((()   |    ()    |   ()))
\  ()  (  .____.  )  ()  /
 |` \_/ \  `""`  / \_/ `|
 |       `.'--'.`       |
  \        `""`        /
   \                  /
    `.              .'    ,
     |`             |  _.'|
     |              `-'  /
     \                 .'
      `.____________.-'");
                Console.WriteLine("YES! You remember now the Ghost. Believed to be a former teacher at 'Strung High',\n Ms. McMurder, the old history teacher. ");
                Console.WriteLine("Her classroom was Room 17, she must be behind this!");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                ghost();
            }
            else if (secChoice == "vampire" || secChoice == "a vampire" || secChoice == "Vampire")
            {
                score1++;
                Console.WriteLine(@"
                /########\
               /##########\
              /   \###/    \
             /     \#/      \
          /\|               |/\
          | | \ ==\    /== / | |
           \|  \<|>\  /<|>/  |/     /|
    \__     |    -   \  -    |     /#|
     \#\     |        |      |   /###|
      \##\   |       \|     |  /#####|
       \###\  |   _______  | /######|
        \####\ | / \/ \/ \|/#######|
        |######\|        |#########|
        |########\______/##########|
        |#########\    /##########/
        |##########\  |#########/\
        /###########\/########/###\
    /################\######/########\
   /##################\###/###########\
  /###################\#/##############\
 /####################/#################\
/###################/####################\");
                Console.WriteLine("YES! You remember now the Vampire. Believed to be a former student at 'Strung High'.");
                Console.WriteLine("He who entered a rageful blood bath, out of his lack of control.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                vampire();
            }
            else
            {
                score1--;
                Console.WriteLine("You must answer the riddle correctly to continue.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                fourth();
            }
        }

        public static void witch()
        {
            Console.Clear();
            Random rnd = new Random();
            string[] secOptions = {
            $"After solving the riddle {passingString} finds in his locker an old army knife, a history book on witches, and a bucket of water."};
            int randomNumber = rnd.Next(0);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);


            if (randomNumber == 1)
            {
                Console.WriteLine($"After careful consideration {passingString} decides to pick the:  ");
                Console.WriteLine("1. Red key");
                Console.WriteLine("2. Black key");
                Console.WriteLine("3. Blue key");
                Console.Write("Choice: ");
                secChoice = Console.ReadLine().ToLower();
                if (secChoice == "1" || secChoice == "red")
                {
                    Console.Clear();
                    score1++;
                    Console.WriteLine("You pick the red key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Room17();

                }
                else if (secChoice == "2" || secChoice == "black")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the black key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Room17();

                }
                else if (secChoice == "3" || secChoice == "blue")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the blue key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Room17();

                }
                else
                {
                    Console.Clear();
                    score1--;
                    Console.WriteLine("You must pick an available option.");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    witch();
                }
            }

            else if (randomNumber == 0)
            {
                Console.WriteLine($"After careful consideration {passingString} decides to pick the:  ");
                Console.WriteLine("1. knife");
                Console.WriteLine("2. history book");
                Console.WriteLine("3. bucket of water");
                Console.Write("Choice: ");
                secChoice = Console.ReadLine().ToLower();
                if (secChoice == "1" || secChoice == "knife")
                {
                    Console.Clear();
                    score1++;
                    Console.WriteLine("You pick the knife");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    knife();
                }
                else if (secChoice == "2" || secChoice == "history book")
                {
                    Console.Clear();
                    score1++;
                    Console.WriteLine("You pick the history book");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    historyBook();
                }
                else if (secChoice == "3" || secChoice == "bucket" || secChoice == "water" || secChoice == "bucket of water")
                {
                    Console.Clear();
                    score1++;
                    Console.WriteLine("You pick the bucket of water");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    bucketWater();
                }
                else
                {
                    Console.Clear();
                    score1--;
                    Console.WriteLine("You must pick an available option.");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    witch();
                }
            }
            else if (randomNumber == 2)
            {
                Console.WriteLine($"After careful consideration {passingString} decides to pick the:  ");
                Console.WriteLine("1. torch");
                Console.WriteLine("2. apple");
                Console.WriteLine("3. gun");
                Console.Write("Choice: ");
                secChoice = Console.ReadLine().ToLower();
                if (secChoice == "1" || secChoice == "torch")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the torch");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    torch();
                }
                else if (secChoice == "2" || secChoice == "apple")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the apple");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    apple();
                }
                else if (secChoice == "3" || secChoice == "gun")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the gun with one bullet.");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    gun();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You must pick an available option.");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    witch();
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("I dont understand that command...");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                witch();
            }
        }

        public static void ghost()
        {
            Console.Clear();
            Random rnd = new Random();
            string[] secOptions = {$"After solving the riddle {passingString} finds 3 keys at the bottom of his locker,\n all of different colour, one red, one black, " +
                    $"one blue.",
            };
            int randomNumber = rnd.Next(0);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);

            if (randomNumber == 0)
            {
                Console.WriteLine($"Clues have been placed throughout the game, choose wisely. \nAfter careful consideration {passingString} decides to pick the:  ");
                Console.WriteLine("1. Red key");
                Console.WriteLine("2. Black key");
                Console.WriteLine("3. Blue key");
                Console.Write("Choice: ");
                secChoice = Console.ReadLine().ToLower();
                if (secChoice == "1" || secChoice == "red")
                {
                    Console.Clear();
                    score1++;
                    Console.WriteLine("You pick the red key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Room17();
                }
                else if (secChoice == "2" || secChoice == "black")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the black key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Room18();

                }
                else if (secChoice == "3" || secChoice == "blue")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the blue key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Room19();

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You must pick an available option.");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    ghost();
                }
            }

            else if (randomNumber == 1)
            {
                Console.WriteLine($"After careful consideration {passingString} decides to pick the:  ");
                Console.WriteLine("1. knife");
                Console.WriteLine("2. history book");
                Console.WriteLine("3. bucket of water");
                Console.Write("Choice: ");
                secChoice = Console.ReadLine().ToLower();
                if (secChoice == "1" || secChoice == "knife")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the knife");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    knife();
                }
                else if (secChoice == "2" || secChoice == "history book")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the history book");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    historyBook();
                }
                else if (secChoice == "3" || secChoice == "bucket" || secChoice == "water" || secChoice == "bucket of water")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the blue key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    bucketWater();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You must pick an available option.");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    witch();
                }
            }
            else if (randomNumber == 2)
            {
                Console.WriteLine($"After careful consideration {passingString} decides to pick the:  ");
                Console.WriteLine("1. torch");
                Console.WriteLine("2. apple");
                Console.WriteLine("3. gun");
                Console.Write("Choice: ");
                secChoice = Console.ReadLine().ToLower();
                if (secChoice == "1" || secChoice == "torch")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the torch");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    torch();
                }
                else if (secChoice == "2" || secChoice == "apple")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the apple");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    apple();
                }
                else if (secChoice == "3" || secChoice == "gun")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the gun with one bullet.");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    gun();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You must pick an available option.");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    witch();
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("I dont understand that command...");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                witch();
            }
        }

        public static void vampire()
        {
            Console.Clear();
            Random rnd = new Random();
            string[] secOptions = { $"After solving the riddle {passingString} finds a torch, an old apple and a gun with one bullet in his locker." };
            int randomNumber = rnd.Next(0);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);

            if (randomNumber == 3)
            {
                Console.WriteLine($"After careful consideration {passingString} decides to pick the:  ");
                Console.WriteLine("1. red key");
                Console.WriteLine("2. black key");
                Console.WriteLine("3. blue key");
                Console.Write("Choice: ");
                secChoice = Console.ReadLine().ToLower();
                if (secChoice == "1" || secChoice == "red")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the red key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Room17();
                }
                else if (secChoice == "2" || secChoice == "black")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the black key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Room17();
                }
                else if (secChoice == "3" || secChoice == "blue")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the blue key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Room17();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You must pick an available option.");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    witch();
                }
            }

            else if (randomNumber == 1)
            {
                Console.WriteLine($"After careful consideration {passingString} decides to pick the:  ");
                Console.WriteLine("1. knife");
                Console.WriteLine("2. history book");
                Console.WriteLine("3. bucket of water");
                Console.Write("Choice: ");
                secChoice = Console.ReadLine().ToLower();
                if (secChoice == "1" || secChoice == "knife")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the knife");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    knife();
                }
                else if (secChoice == "2" || secChoice == "history book")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the history book");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    historyBook();
                }
                else if (secChoice == "3" || secChoice == "bucket" || secChoice == "water" || secChoice == "bucket of water")
                {
                    Console.Clear();
                    Console.WriteLine("You pick the blue key");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    bucketWater();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You must pick an available option.");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    witch();
                }
            }
            else if (randomNumber == 0)
            {
                Console.WriteLine($"After careful consideration {passingString} decides to pick the:  ");
                Console.WriteLine("1. torch");
                Console.WriteLine("2. apple");
                Console.WriteLine("3. gun");
                Console.Write("Choice: ");
                secChoice = Console.ReadLine().ToLower();
                if (secChoice == "1" || secChoice == "torch")
                {
                    Console.Clear();
                    score1++;
                    Console.WriteLine("You pick the torch");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    torch();
                }
                else if (secChoice == "2" || secChoice == "apple")
                {
                    Console.Clear();
                    score1--;
                    Console.WriteLine("You pick the apple");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    apple();
                }
                else if (secChoice == "3" || secChoice == "gun")
                {
                    Console.Clear();
                    score1++;
                    Console.WriteLine("You pick the gun with one bullet.");
                    Console.WriteLine("You close your locker and continue through Strung High.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    gun();
                }
                else
                {
                    Console.Clear();
                    score1--;
                    Console.WriteLine("You must pick an available option.");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    vampire();
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("I dont understand that command...");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                vampire();
            }
        }



        public static void Room17()
        {
            string choice1;
            Console.Clear();
            Console.WriteLine("You frantically move throughout the hall, visons of the bloody past haunt your memory.");
            Console.WriteLine("You feel the presence of Ms. McMurder, is she following you??");
            Console.WriteLine("After failing to find an exit to the school, you continue to search for exits and come across Room 17.");
            Console.WriteLine("Do you enter the room or not? Yes or No.");
            Console.Write("Choice: ");
            choice1 = Console.ReadLine().ToLower();

            switch (choice1)
            {
                case "yes":
                    {

                        Console.Clear();
                        score1++;
                        Console.WriteLine(@"
            __________
           |  __  __  |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |  __  __()|
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |__________|         ");
                        Console.WriteLine($"{passingString} enters Room 17, the door shuts with force behind him,\n and immediately notices three extraordinary doors beaming with light.");
                        Console.WriteLine("One red, one black, and one blue.");
                        Console.WriteLine("Checking his pockets he takes out his key.");
                        Console.WriteLine("Suddenly! The ghost of Ms. McMurder appears. Clear and White with a terrifying contorted face!");
                        Console.WriteLine("You build up the courage and ask, why she brought you here...");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        redDoor();
                        break;
                    }
                case "no":
                    {
                        Console.Clear();
                        score1--;
                        Console.WriteLine($"{passingString} passes Room 17, and aims to find another way out.");
                        Console.WriteLine("After a long search he discovers that every exit is completely shut.");
                        Console.WriteLine($"Becoming exhausted with his search {passingString} falls quickly asleep.");
                        Console.WriteLine("After a period he wakes...");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        gameOver1();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        Room17();
                        break;
                    }
            }
            Console.ReadLine();
        }

        public static void Room18()
        {
            string choice1;
            Console.Clear();
            Console.WriteLine("You frantically move throughout the hall, visons of the bloody past haunt your memory.");
            Console.WriteLine("You feel the presence of Ms. McMurder, is she following you??");
            Console.WriteLine("After failing to find an exit to the school, you continue to search for exits and come across Room 17.");
            Console.WriteLine("Do you enter the room or not? Yes or No.");
            Console.Write("Choice: ");
            choice1 = Console.ReadLine().ToLower();

            switch (choice1)
            {
                case "yes":
                    {
                        Console.Clear();
                        Console.WriteLine($"{passingString} enters Room 17, the door shuts with force behind him,\n and immediately notices three extraordinary doors beaming with light.");
                        Console.WriteLine("One red, one black, and one blue.");
                        Console.WriteLine("Checking his pockets he takes out his key.");
                        Console.WriteLine("Suddenly! The ghost of Ms. McMurder appears. Clear and White with a terrifying contorted face!");
                        Console.WriteLine("You build up the courage and ask, why she brought you here...");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        blueDoor();
                        break;
                    }
                case "no":
                    {
                        Console.Clear();
                        Console.WriteLine($"{passingString} passes Room 17, and aims to find another way out.");
                        Console.WriteLine("After a long search he discovers that every exit is completely shut.");
                        Console.WriteLine($"Becoming exhausted with his search {passingString} falls quickly asleep.");
                        Console.WriteLine("After a period he wakes...");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        gameOver1();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        Room17();
                        break;
                    }
            }
            Console.ReadLine();
        }
        public static void Room19()
        {
            string choice1;
            Console.Clear();
            Console.WriteLine("You frantically move throughout the hall, visons of the bloody past haunt your memory.");
            Console.WriteLine("You feel the presence of Ms. McMurder, is she following you??");
            Console.WriteLine("After failing to find an exit to the school, you continue to search for exits and come across Room 17.");
            Console.WriteLine("Do you enter the room or not? Yes or No.");
            Console.Write("Choice: ");
            choice1 = Console.ReadLine().ToLower();

            switch (choice1)
            {
                case "yes":
                    {
                        Console.Clear();
                        Console.WriteLine($"{passingString} enters Room 17, the door shuts with force behind him,\n and immediately notices three extraordinary doors beaming with light.");
                        Console.WriteLine("One red, one black, and one blue.");
                        Console.WriteLine("Checking his pockets he takes out his key.");
                        Console.WriteLine("Suddenly! The ghost of Ms. McMurder appears. Clear and White with a terrifying contorted face!");
                        Console.WriteLine("You build up the courage and ask, why she brought you here...");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        blackDoor();
                        break;
                    }
                case "no":
                    {
                        Console.Clear();
                        Console.WriteLine($"{passingString} passes Room 17, and aims to find another way out.");
                        Console.WriteLine("After a long search he discovers that every exit is completely shut.");
                        Console.WriteLine($"Becoming exhausted with his search {passingString} falls quickly asleep.");
                        Console.WriteLine("After a period he wakes...");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        gameOver1();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        Room17();
                        break;
                    }
            }
            Console.ReadLine();
        }
        public static void redDoor()
        {
            Console.Clear();
            score1++;
            Console.WriteLine("Ms. McMurder says 'I have brought you here because YOU were the one that got away. \n You never suffered like I did! So today I made you suffer. \n I give you now a choice to pick the right door.");
            Console.WriteLine("Enter a door, I have given you hints throughout your journey on which is the correct door. \n Choose wisely to live, choose wrong and you DIE.");
            Console.WriteLine("Press 'Enter' to unlock the door'");
            Console.ReadLine();
            youSurvived();


        }
        public static void blackDoor()
        {
            Console.Clear();
            score1--;
            Console.WriteLine("Ms. McMurder says 'I have brought you here because YOU were the one that got away. \n You never suffered like I did! So today I made you suffer. \n I give you now a choice to pick the right door.");
            Console.WriteLine("Enter a door, I have given you hints throughout your journey on which is the correct door. \n Choose wisely to live, choose wrong and you DIE.");
            Console.WriteLine("Press 'Enter' to unlock the door'");
            Console.ReadLine();
            gameOver();
        }

        public static void blueDoor()
        {
            Console.Clear();
            score1--;
            Console.WriteLine("Ms. McMurder says 'I have brought you here because YOU were the one that got away. \n You never suffered like I did! So today I made you suffer. \n I give you now a choice to pick the right door.");
            Console.WriteLine("Enter a door, I have given you hints throughout your journey on which is the correct door. \n Choose wisely to live, choose wrong and you DIE.");
            Console.WriteLine("Press 'Enter' to unlock the door'");
            Console.ReadLine();
            gameOver();
        }

        public static void knife()
        {

            Console.Clear();
            string choice3;
            Console.WriteLine(@"
                                                       ___
                                                      |_  |
                                                        | |
__                      ____                            | |
\ ````''''----....____.'\   ````''''--------------------| |--.               _____      .-.
 :.                      `-._                           | |   `''-----''''```     ``''|`: :|
  '::.                       `'--.._____________________| |                           | : :|
    '::..       ----....._______________________________| |                           | : :|
      `'-::...__________________________________________| |   .-''-..-'`-..-'`-..-''-.    :|
           ```'''---------------------------------------| |--'                         `'-'
                                                        | |
                                                       _| |
                                                      |___| ");
            Console.WriteLine("You grab the knife, you are now on the hunt for the witch! You are sick and tired of this silly game \n she is playing with you.");
            Console.WriteLine("You keep the knife close to your side and try to find her.\nNow you are the PREDATOR. ");
            Console.WriteLine("You find a figure. stood still, a silhouette of a witch facing in the other direction.");
            Console.WriteLine("Do you strike the head, or heart, or question her intentions?: ");
            Console.WriteLine("1. Head");
            Console.WriteLine("2. Heart");
            Console.WriteLine("3. Question her");
            Console.Write("Choice: ");
            choice3 = Console.ReadLine().ToLower();
            switch (choice3)
            {
                case "1":
                case "Head":
                    {
                        //continue from here
                        Console.Clear();
                        score1--;
                        string secChoice;
                        Console.WriteLine("Moving closer to the figure you draw the old army knife.");
                        Console.WriteLine("Ready to lunge.");
                        Console.WriteLine("You can smell the stench of blood as you draw nearer.");
                        Console.WriteLine("Press 'Enter' to see what happens next.");
                        Console.ReadLine();
                        Console.WriteLine("WITH FULl FORCE YOU LUNGE AT HER HEAD!!");
                        Console.WriteLine("Only to find the knife has suddenly become a snake.");
                        Console.WriteLine("And the witch was made of confetti. You turn around find\n she is stood behind you.");
                        Console.WriteLine("'You shouldn't have done that' - she says. ");
                        Console.WriteLine("'I present you with two options: Join my cult, or DIE.");
                        Console.WriteLine("1. Join Cult");
                        Console.WriteLine("2. take your chances and run!");
                        Console.Write("Choice: ");
                        secChoice = Console.ReadLine().ToLower();

                        if (secChoice == "1" || secChoice == "Join")
                        {
                            score1++;
                            Console.WriteLine($"She says '{passingString}, I have brought you here to complete my mission from 1999.'");
                            Console.WriteLine("'I murdered those childern to harness their energies, now I will use that to re-create you.'");
                            Console.WriteLine($"{passingString} becomes terrified, but has to join her or die. She comes closer and places her index finger \n on your forehead.");
                            Console.WriteLine("You become reborn as a DEMON. Belonging to the ownership of the witch. You must obey her every command.");
                            Console.WriteLine("Press 'Enter' to continue.");
                            Console.ReadLine();
                            youSurvived1();
                        }
                        else if (secChoice == "2" || secChoice == "run")
                        {
                            Console.Clear();
                            Console.WriteLine("You try to run! She pulls out her wand and you freeze in place.");
                            Console.WriteLine("Press 'Enter' to see what happens next.");
                            Console.ReadLine();
                            gameOver();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("I dont understand that command...");
                            Console.WriteLine("Press 'Enter' to try again.");
                            Console.ReadLine();
                            knife();
                        }

                        break;
                    }
                case "2":
                case "Heart":
                    {
                        Console.Clear();
                        string secChoice;
                        score1++;
                        Console.WriteLine("Moving closer to the figure you draw the old army knife.");
                        Console.WriteLine("Ready to lunge.");
                        Console.WriteLine("You can smell the stench of blood as you draw nearer.");
                        Console.WriteLine("Press 'Enter' to see what happens next.");
                        Console.ReadLine();
                        Console.WriteLine("WITH FULl FORCE YOU LUNGE AT HER HEART!!");
                        Console.WriteLine("You did it! You punctured the heart of the witch, you see blood.");
                        Console.WriteLine("Suddenly she disappears, she must be hurt. Now is your opportunity to \n find her and finish the job.");
                        Console.WriteLine("Or you can look for an exit.");
                        Console.WriteLine("What do you do?: Finish her, or find a way out.");
                        Console.WriteLine("1. Finish that witch");
                        Console.WriteLine("2. Find an exit.");
                        Console.Write("Choice: ");
                        secChoice = Console.ReadLine().ToLower();

                        if (secChoice == "1" || secChoice == "finish her")
                        {
                            Console.WriteLine($"{passingString} takes his knife from the ground, covered in blue blood. ");
                            Console.WriteLine("You decide to trail the blood in search for the witch. ");
                            Console.WriteLine("You follow the blood to Room 69, her old math class.");
                            Console.WriteLine("It seems she has put a spell on the door. \nIt reads 'Answer the following math questions and you may enter!'");
                            Console.WriteLine("Press 'Enter' to continue.");
                            Console.ReadLine();
                            Room69();
                        }
                        else if (secChoice == "2" || secChoice == "run")
                        {
                            Console.Clear();
                            score1--;
                            Console.WriteLine("You try to run! She pulls out her wand and you freeze in place.");
                            Console.WriteLine("Press 'Enter' to see what happens next.");
                            Console.ReadLine();
                            gameOver();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("I dont understand that command...");
                            Console.WriteLine("Press 'Enter' to try again.");
                            Console.ReadLine();
                            knife();
                        }

                        break;
                    }
                case "3":
                case "question":
                    {
                        Console.Clear();
                        Console.WriteLine($"{passingString} builds up the courage and questions her.");
                        Console.WriteLine($"'Why did you bring me here?' says {passingString}, she replies 'You failed math class'.");
                        Console.WriteLine($"'So I wanted to make you into a demon and force you to pass this time.\n It's why I killed those kids. \n BECAUSE YOU FAILED.");
                        Console.WriteLine("Answer my questions and I'll let you leave.'");
                        Console.WriteLine($"{passingString} out of fear, accepts.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Room70();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        Room17();
                        break;
                    }
            }
            Console.ReadLine();
        }

        public static void historyBook()
        {

            Console.Clear();
            score1++;
            Console.WriteLine("You touch the History book of the Old Witches. A strange energy propels throughout your body.");
            Console.WriteLine("The pages start flickering and open to a certain page!");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.WriteLine(@"
      ___________________   ___________________
  .-/|  78   ~~**~~      \ /      ~~**~~   79  |\-.
  ||||                    :                    ||||
  ||||  In this book      :   You must REMEMBER||||
  |||| you will find      :   THE WORDS. VERY  ||||
  |||| the answers on how :   IMPORTANT!!      ||||
  ||||  to kill an evil   :  ~~~~~~~~~~~~~~~~~ ||||
  |||| witch. You must say:  ~~~~~~SHUMA~~~~~~ ||||
  |||| the words 'SHUMA   :  ~~~~~~LAMA~~~~~~~ ||||
  ||||  LAMA DAMA BOOM'   :  ~~~~~~DAMA~~~~~~~ ||||
  |||| This will freeze   :  ~~~~~~BOOM~~~~~~~ ||||
  ||||  her and suffocate :  Propert of Strung ||||
  |||| her to death.      :   High             ||||
  ||||____________________: ___________________||||
  ||/====================\:/====================\||
  `---------------------~___~--------------------''");
            Console.WriteLine("Press 'Enter' to continue the story.");
            Console.ReadLine();

            Console.Clear();
            string choice4;
            Console.WriteLine("You drop the book and carry on to find an exit. ");
            Console.WriteLine("As you walk past Room 69, you begin to feel the presence of the witch once more.");
            Console.WriteLine("Suddenly! You are hit with a freezing spell from the witch from behind.");
            Console.WriteLine("You must say the words you remembered from the book.");
            Console.Write("Words: ");
            choice4 = Console.ReadLine().ToLower();

            if (choice4 == "SHUMA LAMA DAMA BOOM" || choice4 == "shuma lama dama boom")
            {
                Console.Clear();
                score1++;
                Console.WriteLine($"{passingString} reverses the spell!");
                Console.WriteLine("The witch begins to freeze and shatters to pieces.");
                Console.WriteLine("You grab her broom stick and kick it in gear.");
                Console.WriteLine("The book gave you the abilities to harness the power of the witch.");
                Console.WriteLine("You fly through a hole in the roof.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                youSurvived();
            }
            else if (choice4 != "SHUMA LAMA DAMA BOOM")
            {
                Console.Clear();
                score1--;
                Console.WriteLine("You messed up the words because you didnt pay attention.");
                Console.WriteLine("You try to run! She pulls out her wand and you freeze in place.");
                Console.WriteLine("Press 'Enter' to see what happens next.");
                Console.ReadLine();
                gameOver();
            }
        }

        public static void bucketWater()
        {

            Console.Clear();
            Console.WriteLine("You take the bucket and move on throughout the hall.");
            Console.WriteLine("No sign of a witch. In fact you feel no fear at all.");
            Console.WriteLine("The bucket protects. You see something glimmering inside the water. ");
            Console.WriteLine("You reach your hands inside and pull out a sword.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(@"
                           ___
                          ( ((
                           ) ))
  .::.                    / /(
 'M .-;-.-.-.-.-.-.-.-.-/| ((::::::::::::::::::::::::::::::::::::::::::::::.._
(J ( ( ( ( ( ( ( ( ( ( ( |  ))   -====================================-      _.>
 `P `-;-`-`-`-`-`-`-`-`-\| ((::::::::::::::::::::::::::::::::::::::::::::::''
  `::'                    \ \(
                           ) ))
                          (_((");
            Console.WriteLine(" ");
            string choice5;
            Console.WriteLine("The witch appears to you and says 'Follow me to room 69\n and I will explain why you're here'");
            Console.WriteLine("Do you go to ROOM 69, or do you chop off her head?");
            Console.WriteLine("1. Go to Room");
            Console.WriteLine("2. Chop off her head");
            Console.Write("Choice: ");
            choice5 = Console.ReadLine().ToLower();

            if (choice5 == "1" || choice5 == "go to room")
            {
                score1--;
                Console.WriteLine("Hesitantly, you follow her to Room 70.");
                Room70();
            }
            else if (choice5 == "2" || choice5 == "Chop")
            {
                score1++;
                Console.Clear();
                Console.WriteLine("You swing your sword aiming at her head.");
                Console.WriteLine("You miss and slice her nose off.\nAn intense battle takes place with the witch.");

                int playerHp = 40;
                int enemyHp = 70;

                int playerAttack = 5;
                int enemyAttack = 7;

                int healAmount = 5;

                Random random = new Random();

                while (playerHp > 0 && enemyHp > 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("<Player Turn>");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Player Hp = " + playerHp + " Enemy Hp = " + enemyHp);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Enter 'a' to attack or 'h' to heal.");
                    Console.WriteLine(" ");

                    string choice = Console.ReadLine();

                    if (choice == "a")
                    {
                        enemyHp -= playerAttack;
                        Console.WriteLine($"{passingString} attacked the witch and dealt " + playerAttack + " damage!");

                    }
                    else
                    {
                        playerHp += healAmount;
                        Console.WriteLine($"{passingString} " + healAmount + " health points.");
                    }

                    //enemy turn
                    if (enemyHp > 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine("<Enemy turn>");
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Player Hp = " + playerHp + " Enemy Hp = " + enemyHp);
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine(" ");


                        int enemyChoice = random.Next(0, 2);

                        if (enemyChoice == 0)
                        {
                            playerHp -= enemyAttack;
                            Console.WriteLine("The witch attacked and dealt " + enemyAttack + " damage!");
                        }
                        else
                        {
                            enemyHp += healAmount;
                            Console.WriteLine("Witch restored " + healAmount + " health points!");
                        }
                    }
                }

                if (enemyHp == 0)
                {
                    score1++;
                    Console.WriteLine("You did it! You killed the witch.\n You take her broom and begin to fly towards the hole in the roof.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();

                    youSurvived();
                }
                else
                {
                    score1--;
                    Console.WriteLine("You lost to the witch, even with the sword from the bucket.");
                    Console.WriteLine("You were slain.");
                    gameOver();
                }

            }

        }
        //PICK UP FROM HERE WHEN WAKE UP
        public static void torch()
        {
            Console.Clear();
            string choice5;
            Console.WriteLine("The locker shuts and at the end of a dark hall stands the vampire!");
            Console.WriteLine("You quickly turn on the torch too see the figure. But he's disappeared.");
            Console.WriteLine("Using the torch you can finally see clearly.");
            Console.WriteLine("Do you Explore the first floor, find an exit, or run towards the vampire.");
            Console.WriteLine("1. Explore");
            Console.WriteLine("2. Find exit");
            Console.WriteLine("3. Run to vampire");
            Console.Write("Choice: ");
            choice5 = Console.ReadLine().ToLower();
            switch (choice5)
            {
                case "1":
                case "Explore":
                    {
                        //continue from here
                        Console.Clear();
                        score1++;
                        string secChoice;
                        Console.WriteLine($"With the aid of the torch {passingString} tries finding his way around the school. \nLooking for answers to why the vampire brought him here.");
                        Console.WriteLine($"After visiting his old classroom he finds a note laid on his desk. It reads...");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.WriteLine($@"
  ______________________________
 / \                             \.
|   | Dear {passingString},           |.
 \_ |                            |.
    | I have brought you back to |.
    | Strung High for a reason.  |.
    | My old friend...           |.
    | I spared your life that day|.
    | in the year of 1999. You   |.
    |were the only one who didn't|.
    | bully me. With the help of |.
    | Ms.McAlgebra, I became a   |.
    | vampire.I couldn't control.|.
    | HELP ME CHANGE BACK TO WHO |.
    | I WAS. DEFEAT THE WITCH.   |.
    |                from DRAKO  |.
    |  _________________________|___
    \_/dc__________________________/.");
                        Console.WriteLine("Ms.McAlgebra's room was Room 69.\n You can go defeat her to release DRAKO from the vampire spell,\n or fight the vampire.");
                        Console.WriteLine("1. Find the witch");
                        Console.WriteLine("2. Fight DRAKO");
                        Console.Write("Choice: ");
                        secChoice = Console.ReadLine().ToLower();

                        if (secChoice == "1" || secChoice == "find witch")
                        {
                            score1++;
                            Console.Clear();
                            Console.WriteLine("You find a small knife with a blue tip on your desk.");
                            Console.WriteLine($"Now {passingString} leaves the classroom to find Room 69. ");

                            Console.WriteLine("Press 'Enter' to continue.");
                            Console.ReadLine();
                            Room71();
                        }
                        else if (secChoice == "2" || secChoice == "fight drako")
                        {
                            Console.WriteLine("After refusing to help the vampire he becomes angry and does not let you leave.");
                            Console.WriteLine("In a rage he wants blood and begins to fight you.");
                            Console.WriteLine("Press 'Enter' to continue.");
                            Console.ReadLine();
                            score1++;
                            Console.Clear();
                            Console.WriteLine("He strikes first!");
                            Console.WriteLine("You use the light from the torch as a weapon.");

                            int playerHp = 40;
                            int enemyHp = 50;

                            int playerAttack = 5;
                            int enemyAttack = 7;

                            int healAmount = 5;

                            Random random = new Random();

                            while (playerHp > 0 && enemyHp > 0)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("<Player Turn>");
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine("Player Hp = " + playerHp + " Enemy Hp = " + enemyHp);
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");
                                Console.WriteLine(" ");

                                string choice = Console.ReadLine();

                                if (choice == "a")
                                {
                                    enemyHp -= playerAttack;
                                    Console.WriteLine($"{passingString} attacked the vampire and dealt " + playerAttack + " damage!");

                                }
                                else
                                {
                                    playerHp += healAmount;
                                    Console.WriteLine($"{passingString} " + healAmount + " health points.");
                                }

                                //enemy turn
                                if (enemyHp > 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("<Enemy turn>");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("Player Hp = " + playerHp + " Enemy Hp = " + enemyHp);
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine(" ");


                                    int enemyChoice = random.Next(0, 2);

                                    if (enemyChoice == 0)
                                    {
                                        playerHp -= enemyAttack;
                                        Console.WriteLine("The vampire attacked and dealt " + enemyAttack + " damage!");
                                    }
                                    else
                                    {
                                        enemyHp += healAmount;
                                        Console.WriteLine("vampire restored " + healAmount + " health points!");
                                    }
                                }
                            }

                            if (enemyHp == 0)
                            {
                                score1++;
                                Console.WriteLine("You did it! You killed the Vampire.\n You take his cloak and begin to fly towards the hole in the roof.");
                                Console.WriteLine("Press 'Enter' to continue.");
                                Console.ReadLine();

                                youSurvived();
                            }
                            else
                            {
                                score1--;
                                Console.WriteLine("You lost to the vampire, even with the torches light.");
                                Console.WriteLine("You were slain.");
                                gameOver();
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("I dont understand that command...");
                            Console.WriteLine("Press 'Enter' to try again.");
                            Console.ReadLine();
                            torch();
                        }

                        break;
                    }
                case "2":
                case "find exit":
                    {
                        Console.Clear();
                        string secChoice;
                        score1++;
                        Console.WriteLine("You decide enough is enough and decide to find a way out of this hell hole.");
                        Console.WriteLine("Drako the Vampire tries to attack for disobeying him.");
                        Console.WriteLine("you use the light from the torch to your advantage and finally find an open exit.");
                        Console.WriteLine("You have an opening to escape. Do you take it?: YES OR NO");
                        Console.Write("Choice: ");
                        secChoice = Console.ReadLine().ToLower();

                        if (secChoice == "yes")
                        {
                            score1++;
                            Console.WriteLine($"{passingString} throws his torch at DRAKO");
                            Console.WriteLine("And jumps through the window landing on the grass outside.");
                            Console.ReadLine();
                            youSurvived();
                        }
                        else if (secChoice == "no")
                        {
                            Console.Clear();
                            score1--;
                            Console.WriteLine("You failed to take the correct opportunity.\nThis has led to your demise.");
                            Console.WriteLine("Press 'Enter' to see what happens next.");
                            Console.ReadLine();
                            gameOver();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("I dont understand that command...");
                            Console.WriteLine("Press 'Enter' to try again.");
                            Console.ReadLine();
                            torch();
                        }

                        break;
                    }
                case "3":
                case "run":
                    {

                        score1--;
                        Console.Clear();
                        Console.WriteLine("You begin to run at the last place you saw the vampire.");
                        Console.WriteLine("You use the shine from the torch to deal damage to the vampire.");
                        Console.WriteLine("As you run around the corner, he swings at you with his claws.\n You enter into an intense battle. YOU LOSE.");
                        Console.ReadLine();
                        gameOver();

                        break;
                    }
            }
            Console.ReadLine();

        }

        public static void apple()
        {

            Console.Clear();
            string choice6;
            Console.WriteLine("You take the apple. Do you eat it or pocket it?");
            Console.WriteLine("1. Eat");
            Console.WriteLine("2. Store");
            Console.Write("Choice: ");
            choice6 = Console.ReadLine().ToLower();

            if (choice6 == "1" || choice6 == "eat")
            {
                Console.Clear();
                Console.WriteLine("You eat the old apple and begin to throw up.");
                Console.WriteLine("You quickly realise that was a bad decision.");
                Console.WriteLine("However, you must carry on and look for escape.");
                Console.WriteLine("Now feeling dizzy you move throughout the hall, seeing visions of monsters, witches and ghosts.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.WriteLine(@"
\                           /
 \                         /
  \                       /
   ]                     [    ,'|
   ]                     [   /  |
   ]___               ___[ ,'   |
   ]  ]\             /[  [ |:   |
   ]  ] \           / [  [ |:   |
   ]  ]  ]         [  [  [ |:   |
   ]  ]  ]__     __[  [  [ |:   |
   ]  ]  ] ]\ _ /[ [  [  [ |:   |
   ]  ]  ] ] (#) [ [  [  [ :===='
   ]  ]  ]_].nHn.[_[  [  [
   ]  ]  ]  HHHHH. [  [  [
   ]  ] /   `HH(""N  \ [  [
   ]__]/     HHH  ""  \[__[
   ]         NNN         [
   ]         N/""         [
   ]         N H         [
  /          N            \
 /           q,            \
/                           \");
                Console.WriteLine(" ");
                Console.WriteLine("You are now stuck in an endless search for escape");
                Console.WriteLine("Becoming tired you fall asleep, you see glimpss of a vampire, a witch \nand a ghost standing over you.");
                Console.ReadLine();
                gameOver1();

            }
            else if (choice6 == "2" || choice6 == "store")
            {
                Console.WriteLine("You place the apple in your pocket. The vampire approaches you...");
                Console.WriteLine("He says 'I am DRAKO your old classmate.' You immediately recognise him.");
                Console.WriteLine("You ask him why he brought you here. DRAKO says 'I need to be freed from the grasp of the evil witch,\n and you were the only one who could escape her.");
                Console.WriteLine($"{passingString} says 'I will help you only if you eat thise apple.' DRAKO agrees to eat the apple.");
                Console.WriteLine("Slowly he starts to become a human again. Just then a green smoke enters the hall. The witch appears before them.");
                Console.WriteLine("She says 'Both of you failed my math class, to survive answer these questions.");
                Console.ReadLine();
                Console.WriteLine("Press 'Enter' to continue");
                Room71();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("I dont understand that command...");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                apple();
            }
            Console.ReadLine();
        }

        public static void gun()
        {

            Console.Clear();
            Console.WriteLine(@" \
 /                                 />
 \__+_____________________/\/\___/ /|
 ()______________________      / /|/\
             /0 0  ---- |----    /---\
            |0 o 0 ----|| - \ --|      \
             \0_0/____/ |    |  |\      \
                         \__/__/  |      \
                                  |       \
                                  |         \
                                  |__________|
");
            Console.WriteLine("You take the gun and put the bullet inside the revoloving chamber.\n You're ready for action.");
            Console.WriteLine("You hold the gun up Gangsta style.");
            Console.WriteLine("You walk back up the stairs to the hall with the dim light. \nYou will try to break the glass window and escape by jumping.");
            Console.WriteLine($"{passingString} reaches the hall and immediately feels the presence of the vampire.");
            Console.WriteLine("You call 'COME OUT NOW OR I'LL BLOW YOUR BRAINS OUT B****'.\n The vampire comes out of the shadows and says\n answer these questions correctly and i'll let you live.");

            string[] answer = { "pacific", "asia", "rest in peace", "ghostbusters" };

            string answer1;
            string answer2;
            string answer3;
            string answer4;
            int point = 0;

            Console.Write("DRAKO says 'What Ocean has the most area?': ");
            answer1 = Console.ReadLine();
            if (answer1 == answer[0])
            {
                point += 1;
                Console.WriteLine("Correct.");
            }
            else
            {
                point -= 1;
                Console.WriteLine("Wrong answer");
            }

            Console.Write("Which is the largest continent by area?: ");
            answer2 = Console.ReadLine();
            if (answer2 == answer[1])
            {
                point += 1;
                Console.WriteLine("Correct.");
            }
            else
            {
                point -= 1;
                Console.WriteLine("Wrong answer");
            }

            Console.Write("What does RIP mean?: ");
            answer3 = Console.ReadLine();
            if (answer3 == answer[2])
            {
                point += 1;
                Console.WriteLine("Correct.");
            }
            else
            {
                point -= 1;
                Console.WriteLine("Wrong answer");
            }

            Console.Write("Who you gonna CALL?: ");
            answer4 = Console.ReadLine();
            if (answer4 == answer[3])
            {
                point += 1;
                Console.WriteLine("Correct.");
            }
            else
            {
                point -= 1;
                Console.WriteLine("Wrong answer");
            }
            Console.WriteLine("You got " + point + " points");
            Console.WriteLine("Good job you answered well.\n You empty the chamber in the vampires face and walk out the front door.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            youSurvived();
        }

        public static void Room69()
        {
            int score = 0;


        start:
            Console.Clear();
            Console.WriteLine("Welcome to Math Class, answer these questions correctly.");

            Console.WriteLine("Press 'Enter' to start");
            Console.ReadLine();
            Console.WriteLine("8 x 11 = ?");
            string line = Console.ReadLine();

            if (line == "88")
            {
                score++;
                Console.WriteLine("88 + 12 = ?");
                string line1 = Console.ReadLine();
                if (line1 == "100")
                {
                    score++;
                    Console.WriteLine("2 x 100 + 45 = ?");
                    string line2 = Console.ReadLine();
                    if (line2 == "245")
                    {
                        score++;
                        Console.WriteLine("245 + 245 = ?");
                        string line3 = Console.ReadLine();
                        if (line3 == "490")
                        {
                            score++;
                            Console.WriteLine("2 x 490 = ?");
                            string line4 = Console.ReadLine();
                            if (line4 == "980")
                            {
                                score++;
                                Console.WriteLine($"Your score is {score}");
                                Console.WriteLine("Press 'Enter' to continue.");
                                Console.ReadLine();
                            }
                        }
                    }
                }

            }
            else
            {
                score--;
                goto start;
            }
            score1++;
            Console.WriteLine("You find the witch in the room bleeding, aswell as an open door. ");
            Console.WriteLine("The witch tries one last time to cast a spell, she reaches for her wand!");
            Console.WriteLine("You throw the knife straight into her eye socket!");
            Console.WriteLine("You walk through the door to safety and kick the witches face on the way out.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            youSurvived();
        }

        public static void Room70()
        {
            int score = 0;
            bool ifright;

        start:
            Console.Clear();
            Console.WriteLine("Welcome to Math Class, to enter answer these questions correctly.");
            Console.WriteLine("I brought you to this school because you failed my math class");
            Console.WriteLine("Dont fail this time or there will be dire consequences.");
            Console.WriteLine("Press 'Enter' to start");
            Console.ReadLine();
            Console.WriteLine("8 x 11 = ?");
            string line = Console.ReadLine();

            if (line == "88")
            {
                score++;
                Console.WriteLine("88 + 12 = ?");
                string line1 = Console.ReadLine();
                if (line1 == "100")
                {
                    score++;
                    Console.WriteLine("2 x 100 + 45 = ?");
                    string line2 = Console.ReadLine();
                    if (line2 == "245")
                    {
                        score++;
                        Console.WriteLine("245 + 245 = ?");
                        string line3 = Console.ReadLine();
                        if (line3 == "490")
                        {
                            score++;
                            Console.WriteLine("2 x 490 = ?");
                            string line4 = Console.ReadLine();
                            if (line4 == "980")
                            {
                                score++;
                                Console.WriteLine($"Your score is {score}");
                                Console.WriteLine("Press 'Enter' to continue.");
                                Console.ReadLine();
                            }
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("I told you if you fail what would happen!");
                Console.WriteLine($"The witch pulls out her wand and kills {passingString}");
                score--;
                score1--;
                gameOver();
            }
            score1++;
            Console.WriteLine("After answering the questions correctly. The witch promises that you may leave.");
            Console.WriteLine("She says on your way out 'Next time...don't fail'.");
            Console.WriteLine("This pisses you off. So you slash her head off with the sword you pulled from the bucket.");
            Console.WriteLine("You walk through the door to safety and kick the witches head on the way out.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            youSurvived();
        }

        public static void Room71()
        {
            int score = 0;
            bool ifright;

        start:
            Console.Clear();
            Console.WriteLine("You reach the entrance of Room 69. It reads ..");
            Console.WriteLine("Welcome to Math Class, to enter answer these questions correctly.");
            Console.WriteLine("Dont fail or there will be dire consequences.");
            Console.WriteLine("Press 'Enter' to start");
            Console.ReadLine();
            Console.WriteLine("8 x 11 = ?");
            string line = Console.ReadLine();

            if (line == "88")
            {
                score++;
                Console.WriteLine("88 + 12 = ?");
                string line1 = Console.ReadLine();
                if (line1 == "100")
                {
                    score++;
                    Console.WriteLine("2 x 100 + 45 = ?");
                    string line2 = Console.ReadLine();
                    if (line2 == "245")
                    {
                        score++;
                        Console.WriteLine("245 + 245 = ?");
                        string line3 = Console.ReadLine();
                        if (line3 == "490")
                        {
                            score++;
                            Console.WriteLine("2 x 490 = ?");
                            string line4 = Console.ReadLine();
                            if (line4 == "980")
                            {
                                score++;
                                Console.WriteLine($"Your score is {score}");
                                Console.WriteLine("Press 'Enter' to continue.");
                                Console.ReadLine();
                            }
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("I told you if you fail what would happen!");
                Console.WriteLine($"The witch pulls out her wand and kills {passingString}");
                score--;
                score1--;
                gameOver();
            }
            score1++;
            Console.WriteLine("After answering the questions correctly. The witch stands in the middle of the room.");
            Console.WriteLine("You ask her to release the vampire. She refuses and says 'Only if you take his place'.");
            Console.WriteLine("This annoys you. So you throw small knife in her eye socket and kill her.");
            Console.WriteLine("You walk through the door to safety and kick the witches head on the way out.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            youSurvived();
        }






        public static void youSurvived()
        {
            Console.Clear();
            Console.WriteLine($"Your score is {score1}");
            Console.WriteLine("Beat your score with another try! ");
            Console.WriteLine("You succesfully made it out of the school alive.");
            Console.WriteLine("You chose the correct paths and remained relatively unharmed.");
            Console.WriteLine("Play again by pressing 'Enter'");
            Console.ReadLine();
            Console.Clear();
            score1 = 0;
            Game constructorClass = new Game();
            constructorClass.Start();
        }

        public static void youSurvived1()
        {
            Console.Clear();
            Console.WriteLine($"Your score is {score1}");
            Console.WriteLine("Beat your score with another try! ");
            Console.WriteLine("You remained alive but live in a miserable existence.");
            Console.WriteLine("The witch stole your free will when you joined her cult.\n You're as good as DEAD.");

            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            score1 = 0;
            Game constructorClass = new Game();
            constructorClass.Start();
        }

        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine($"Your score is {score1}");
            Console.WriteLine("Beat your score with another try! ");
            Console.WriteLine("You were unable to find the correct path to survive.");
            Console.WriteLine("You die a horrible and painful death.");
            Console.WriteLine(" ");
            Console.WriteLine("Try again by pressing 'Enter'");
            Console.ReadLine();
            Console.Clear();
            score1 = 0;
            Game constructorClass = new Game();
            constructorClass.Start();
        }
        public static void gameOver1()
        {
            Console.Clear();

            Console.WriteLine($"{passingString} cannot move!");
            Console.WriteLine("Sleep paralysis overtakes you. Constricting your breathing. ");
            Console.WriteLine("After a long period of time, You die from hunger, unable to move.");
            Console.WriteLine("You were unsuccessful and did not find the right path.");
            Console.WriteLine(" ");
            Console.WriteLine($"Your score is {score1}");
            Console.WriteLine("Beat your score with another try! ");
            Console.WriteLine("Try again by pressing 'Enter'");
            Console.ReadLine();
            score1 = 0;
            Console.Clear();
            Game constructorClass = new Game();
            constructorClass.Start();
        }
    }
}





