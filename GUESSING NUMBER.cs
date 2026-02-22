using System;
namespace BroCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playing = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String playAgain;

            while(playing)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);

                while(guess != number)
                {
                    Console.WriteLine("Guess a number between 1 - 100");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess < number)
                    {
                        Console.WriteLine("Too LOW!");
                    }
                    else if (number < guess)
                    {
                        Console.WriteLine("Too HIGH!");
                    }
                    guesses += 1;
                }
                
                Console.WriteLine("You WIN!" + "The number was: " + number);
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Play again? (YES/NO)");
                playAgain = Console.ReadLine();
                playAgain = playAgain.ToUpper();

                if(playAgain == "YES")
                {
                    playing = true;
                }
                else if (playAgain == "NO")
                {
                    playing = false;
                }

            }
            Console.WriteLine("Thanks for playing :)");
            Console.ReadKey();

        }
    }
}
