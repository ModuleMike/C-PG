

namespace GuessingGame
{
    public class App
    {

        public static void Run()
        {
            GameManager manager = new GameManager();

            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Guessing Game!");
                int maxGuess = ConsoleIO.GetMaxNumber();

                manager.GenerateNumber(maxGuess);

                Console.WriteLine($"I'm thinking of a number between 1 and {maxGuess}. Can you Guess it?");
                int guesscount = 0;
                bool guessed = false;

                while (!guessed)
                {
                    int guess = ConsoleIO.GetGuess(maxGuess);
                    guesscount++;
                    guessed = manager.ParseGuess(guess);
                }

                Console.WriteLine($"It took you {guesscount} guesses.");

            } while (ConsoleIO.PlayAgain());

          
        }

    }
}
