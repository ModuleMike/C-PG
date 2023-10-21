int AskForNumber(string text)
{
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out int output))
        {
            return output;
        }
        else
        {
            Console.WriteLine("Invalid input. Try Again");
        }
        
    } 
}

int AskForNumberInRange( string text, int min, int max)
{
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out int output) && output > min && output < max)
        {
            return output;
        }
        else
        {
            Console.WriteLine("Invalid input. Try Again");
        }
    }
}

AskForNumber("What is the airspeed velocity of an unladen swallow? ");
AskForNumberInRange("What about in he range of 1 - 120?", 1, 121);