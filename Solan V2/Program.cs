for (int number = 1; number <= 100; number++)
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{number}: Electric & Fire!!");
    }
    else if ( number % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{number}: Fire!!");
    }
    else if ( number % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{number}: Electric!!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{number}: Normal!!");
    }