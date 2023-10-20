namespace VinFletchersArrows
{
    public class ConsoleIO
    {
        public static ArrowHead HeadSelection()
        {
            while (true)
            {
                Console.Write($"Enter Arrow Head Selection, options are {ArrowHead.Steel}, {ArrowHead.Wood}, or {ArrowHead.Obsidian}:  ");
                string prompt = Console.ReadLine();
                if (Enum.TryParse(prompt, out ArrowHead headChoice))
                {
                    return headChoice;
                }
                Console.WriteLine($"Invalid Selection. Must be {ArrowHead.Steel}, {ArrowHead.Wood}, or {ArrowHead.Obsidian}.\n");
            }
        }
        public static Fletching FletchingSelection()
        {
            while (true)
            {
                Console.Write($"\nEnter Fletching Selection, options are {Fletching.Plastic}, {Fletching.TurkeyFeathers}, or {Fletching.GooseFeathers}:  ");
                string prompt = Console.ReadLine();
                if (Enum.TryParse(prompt, out Fletching fletchingChoice))
                {
                    return fletchingChoice;
                }
                Console.WriteLine($"Invalid Selection. Must be {Fletching.Plastic}, {Fletching.TurkeyFeathers}, or {Fletching.GooseFeathers}.\n");
            }
        }
        public static float LengthSelection(float min, float max)
        {
            while (true)
            {
                Console.Write($"\nEnter Length Selection, must values between {min}cm  and {max}cm:  ");
                if(float.TryParse(Console.ReadLine(), out float lengthChoice) && lengthChoice > min && lengthChoice < max);
                {
                    return lengthChoice;
                }
                Console.WriteLine($"Invalid Selection. Must be between {min}cm and {max}cm.\n");
            }
        }
        public static void Receipt(float total)
        {
            Console.WriteLine($"Your total is {total} gold.");
        }
    }
}
