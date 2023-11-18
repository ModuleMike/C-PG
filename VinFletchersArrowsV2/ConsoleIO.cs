namespace VinFletchersArrows
{
    public class ConsoleIO
    {
        public static Head HeadSelect()
        {
            while (true)
            {
                Console.Write($"Enter Arrow Head Selection, options are {Head.Steel}, {Head.Wood}, or {Head.Obsidian}:  ");
                if (Enum.TryParse(ML.S_CapFirst(Console.ReadLine().ToLower()), out Head output))
                {
                    return output;
                }
                Console.WriteLine($"Invalid Selection. Must be {Head.Steel}, {Head.Wood}, or {Head.Obsidian}.\n");
            }
        }
        public static Fletch FletchSelect()
        {
            while (true)
            {
                Console.Write($"\nEnter Fletch Selection, options are {Fletch.Plastic}, {Fletch.Turkeyfeathers}, or {Fletch.Goosefeathers}:  ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(Console.ReadLine()))
                {
                    string input = Console.ReadLine();
                    if (Enum.TryParse(ML.S_CapFirst(input), out Fletch output))
                    {
                        return output;
                    }
                }
                Console.WriteLine($"Invalid Selection. Must be {Fletch.Plastic}, {Fletch.Turkeyfeathers}, or {Fletch.Goosefeathers}.\n");
            }
        }
        public static float LengthSelect(float min, float max)
        {
            while (true)
            {
                Console.Write($"\nEnter Length Selection, must values between {min}cm  and {max}cm:  ");
                if (float.TryParse(Console.ReadLine(), out float output) && output >= min && output <= max)
                {
                    return output;
                }
                Console.WriteLine($"Invalid Selection. Must be between {min}cm and {max}cm.\n");
            }
        }
        public static void OrderReceipt(float total)
        {
            Console.WriteLine($"Your total is {total} gold.");
        }
    }
}