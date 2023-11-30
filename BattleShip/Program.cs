int number = AskForNumberInRange("Player 1 Guess A Number Between 1 - 100: ", 1, 100);

Console.Clear();

Console.WriteLine("Player 2 it is your turn to try and guess the number...");

while (true)
{
    int guess = AskForNumber("Guess the number... ");
    if (guess < number) Console.WriteLine($"{guess} is to low!!");
    else if (guess > number) Console.WriteLine($"{guess} is to High!!");
    else break;
}

Console.WriteLine($"{number} is the the right number!!");

int AskForNumberInRange(String text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
        return number;
    }

}

int AskForNumber(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}