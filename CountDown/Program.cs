for( int x = 10; x > 0; x--)
{
    Console.WriteLine(x);
}

int CountDown(int number)
{
    if(number == 1)
    {
        Console.WriteLine(number);
        return 1;
    }
    Console.WriteLine(number);
    return CountDown(number - 1);
    
}

CountDown(20);
