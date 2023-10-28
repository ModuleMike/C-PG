int player1Num, player2Guess;

do
{
    Console.Write("Player 1... Choose a number between 0 and 100: ");
    player1Num = Convert.ToInt32(Console.ReadLine());
}
while (player1Num < 0 || player1Num > 100);

Console.Clear();


Console.WriteLine("Player 2 It Is Your Turn To Guess The Number... ");
Console.Write("Player 2 What Is Your First Guess? ");
player2Guess = Convert.ToInt32(Console.ReadLine());


while (player1Num != player2Guess)
{
    if (player2Guess > player1Num)
    {
        Console.WriteLine("This number is two high!");
        Console.Write("Player 2 What Is Your Next Guess?? ");
        player2Guess = Convert.ToInt32(Console.ReadLine());
        continue;
    }
    else if (player2Guess < player1Num)
    {
        Console.WriteLine("This number is two Low!");
        Console.Write("Player 2 What Is Your Next Guess?? ");
        player2Guess = Convert.ToInt32(Console.ReadLine());
        continue;
    }
}

Console.WriteLine($"You Guess the number! The Number was {player1Num}!");
