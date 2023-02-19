using System;
using System.Text;

class Programm
{
    public static void Main()
    {
        Random random = new Random();

        String version = "1.2";

        int randomNum = 0;
        int winNum = random.Next(0, randomNum);
        int tries = 0;
        bool win = false;

        bool started = false;

        bool color = true;

        Console.Title = "PixiNumber Guess " + version;
        startScreen();

        do
        {
            if (started)
            {
                Console.Write("Guess a Number in between 0 and " + randomNum + ": ");
                String getNum = Console.ReadLine();
                int i = int.Parse(getNum);

                if (i > winNum)
                {
                    if(color)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Too High! Guess Lower...");
                    }
                    if (!color)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Too High! Guess Lower...");
                    }
                    tries++;
                }

                if (i < winNum)
                {
                    if (color)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Too Low! Guess Lower...");
                    }
                    if (!color)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Too Low! Guess Lower...");
                    }
                    tries++;
                }

                if (i == winNum)
                {
                    winScreen();
                }
            }

        } while (win == false);

        void startScreen()
        {
            if (color)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine(" [ - PixiStudios Presents - ] ");
                Thread.Sleep(1500);
                Console.Clear();
                Console.WriteLine(" { - PixiNumber Guess - } ");
                Thread.Sleep(1500);
                Console.Clear();
                Thread.Sleep(100);
            }
            if (!color)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" [ - PixiStudios Presents - ] ");
                Thread.Sleep(1500);
                Console.Clear();
                Console.WriteLine(" { - PixiNumber Guess - } ");
                Thread.Sleep(1500);
                Console.Clear();
                Thread.Sleep(100);
            }

            menuScreen();
        }

        void menuScreen()
        {
            Console.Clear();
            if (color)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("PixiNumber Guess");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("     Start      ");
                Console.WriteLine("    Settings    ");
                Console.WriteLine();
            }
            if (!color)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("PixiNumber Guess");
                Console.WriteLine();
                Console.WriteLine("     Start     ");
                Console.WriteLine("    Settings   ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Input: ");


            String getInput = Console.ReadLine();
            switch(getInput)
            {
                case "start":
                    chooseDifficulty();
                    break;
                case "settings":
                    settingsScreen();
                    break;
                default:
                    if (color)
                        Console.WriteLine();
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please choose an option that exists");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    if (!color)
                    {
                        Console.WriteLine("Please choose an option that exists");
                    }
                    Thread.Sleep(1500);
                    menuScreen();
                    break;
            }
        }

        void settingsScreen()
        {
            Console.Clear();
            Console.WriteLine("Settings:");
            Console.WriteLine();
            if (color)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Color=" + color);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exit");
                Console.ForegroundColor = ConsoleColor.White;


            }
            if (!color)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Color=" + color);
                Console.WriteLine();
                Console.WriteLine("Exit");
                
                
            };       
            Console.WriteLine();
            Console.Write("Input: ");

            String getInput = Console.ReadLine();
            switch (getInput)
            {
                case "color=true":
                    color = true;
                    Console.WriteLine();
                    Console.WriteLine("Color=" + color);
                    Thread.Sleep(1500);
                    Console.Clear();
                    settingsScreen();
                    break;
                case "color=false":
                    color = false;
                    Console.WriteLine();
                    Console.WriteLine("Color=" + color);
                    Thread.Sleep(1500);
                    Console.Clear();
                    settingsScreen();
                    break;
                case "exit":
                    menuScreen();
                    break;
                default:
                    if (color)
                        Console.WriteLine();
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please choose an option that exists");
                        Console.ForegroundColor = ConsoleColor.White;
                        
                    }
                    if (!color)
                    {
                        Console.WriteLine("Please choose an difficulty that exists");
                    }
                    Console.WriteLine("Example: color=true");
                    Thread.Sleep(2000);
                    settingsScreen();
                    break;
            }
        }

        void chooseDifficulty()
        {
            if (color)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Please select a Difficulty!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" - Easy");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" - Medium");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" - Hard");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Input: ");
            }

            if (!color)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Please select a Difficulty!");
                Console.WriteLine(" - Easy");
                Console.WriteLine(" - Medium");
                Console.WriteLine(" - Hard");
                Console.WriteLine();
                Console.Write("Input: ");
            }
           

            String getInput = Console.ReadLine();

            switch (getInput)
            {
                case "easy":
                    randomNum = 10;

                    started = true;
                    break;
                case "medium":
                    randomNum = 100;

                    started = true;
                    break;
                case "hard":
                    randomNum = 1000;

                    started = true;
                    break;
                default:
                    if (color)
                        Console.WriteLine();
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please choose an difficulty that exists");
                        Console.ForegroundColor = ConsoleColor.White;
                    } 
                    if (!color)
                    {
                        Console.WriteLine("Please choose an difficulty that exists");
                    }
                    Thread.Sleep(1500);
                    chooseDifficulty();

                    break;
            }
            winNum = random.Next(0, randomNum);
        }

        void winScreen()
        {
            if (color)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (!color)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Clear();
            Console.WriteLine("WON!");
            Console.WriteLine("Tries: " + tries);
            Thread.Sleep(3000);
            win = true;
            resetGame();
        }

        void resetGame()
        {
            Console.Clear();
            win = false;
            tries = 0;
            started = false;

            chooseDifficulty();
        }



    }


}