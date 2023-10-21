namespace VinFletchersArrows
{
    public class Arrow
    {
        public static (Head, Fletch, float) PremadeOrder(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (char.TryParse(Console.ReadLine().Trim().ToUpper(), out char output))
                    switch (output)
                    {
                        case 'E':   // Elite Premade 
                            return (Head.Steel, Fletch.Plastic, 95f);
                        case 'M':   // Marksman Premade
                            return (Head.Wood, Fletch.Goosefeathers, 75f);
                        case 'J':   // Junior Premade
                            return (Head.Obsidian, Fletch.Turkeyfeathers, 65f);
                        default:
                            Console.WriteLine($"Invalid Selection. Options - 'E' , 'M', J'\n");
                            break;
                    }
            }
        }
        public static (Head, Fletch, float) CustomOrder()
        {
            float _minLength = 50f;
            float _maxLength = 100f;
            Head headselect = ConsoleIO.HeadSelect();   // Head Selection
            Fletch fletchselect = ConsoleIO.FletchSelect(); //Fletch Selection
            float lengthselect = ConsoleIO.LengthSelect(_minLength, _maxLength);  // Length Selection
            return (headselect, fletchselect, lengthselect);
        }
        public static float CheckOut(Head head, Fletch fletch, float length)
        {
            float total = (float)head + (float)fletch + (length * 0.05f);
            Console.WriteLine($"That Arrow is {total} gold.");
            return total;
        }
    }
    public enum Head
    {
        Steel = 10,
        Wood = 3,
        Obsidian = 5
    }
    public enum Fletch
    {
        Plastic = 10,
        Turkeyfeathers = 5,
        Goosefeathers = 3
    }
}