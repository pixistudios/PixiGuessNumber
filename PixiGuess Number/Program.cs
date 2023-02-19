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


        Console.Title = "PixiNumber Guess " + version;
        startScreen();

        do
        {
            if (started)
            {
                Console.Write("Guess a Number in between 0 and " + randomNum + ": ");
            }

            String getNum = Console.ReadLine();
            int i = int.Parse(getNum);

            if (i > winNum)
            {
                Console.WriteLine("Too High! Guess Lower...");
                tries++;
            }

            if (i < winNum)
            {
                Console.WriteLine("Too Low! Guess Higher...");
                tries++;
            }

            if (i == winNum)
            {
                winScreen();
            }

        } while (win == false);

        void startScreen()
        {
            Console.WriteLine(" [ - PixiStudios Presents - ] ");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine(" { - PixiNumber Guess - } ");
            Thread.Sleep(1500);
            Console.Clear();
            Thread.Sleep(100);
            chooseDifficulty();
        }

        void chooseDifficulty()
        {
            Console.Clear();
            Console.WriteLine("Please select a Difficulty!");
            Console.WriteLine(" - Easy");
            Console.WriteLine(" - Medium");
            Console.WriteLine(" - Hard");
            Console.WriteLine();

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
                    Console.WriteLine();
                    Console.WriteLine("Please choose an difficulty that exists");
                    break;
            }
            winNum = random.Next(0, randomNum);
        }

        void winScreen()
        {
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