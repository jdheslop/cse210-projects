using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        string playAgain = "yes";
        int guess;

        
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());


        while (playAgain == "yes")
        {
            int counter = 0;
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            do
            {
                counter ++;
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);

                if (magicNumber < guess)
                {
                    Console.WriteLine("The magic number is lower.");
                }
                else if (magicNumber > guess)
                {
                    Console.WriteLine("The magic number is higher.");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {counter} guesses.");
                }
            } while (magicNumber != guess);

            Console.WriteLine();        
            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine();
            Console.WriteLine();
        }
        
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine();
    }
}