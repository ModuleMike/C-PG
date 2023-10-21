namespace VinFletchersArrows
{
    public class ConsoleIO
    {
        public static bool CustomOrPremade()
        {
            while (true)
            {
                Console.WriteLine("Vin Fletcher Elite Arrow");
                Console.Write("(P)remade or (C)ustom?  ");
                string input = Console.ReadLine().Trim().ToUpper();
                switch (input)
                {
                    case "P":
                        return true;
                    case "C":
                        return false;
                    default:
                        Console.WriteLine("Invalid Selection. Must be (Premade) or (Custom).");
                        break;
                }
            }
        }
        public static string SelectPremade()
        {
            Console.Clear();
            Console.WriteLine($"Vin Fletcher Elite Arrow            Signature Select");
            Console.WriteLine("(E)lite Signature Select    - - - >  Steel- Plastic - 95cm");
            Console.WriteLine("(M)arksman Signature Select - - - >  Steel/Plastic/95cm");
            Console.WriteLine("(J)unior Signature Select   - - - >  Wood/Goosefeathers/95cm");
            return "\nAdd E, M, or J: ";
        }
        public static Head HeadSelect()
        {
            while (true)
            {
                Console.Write($"\nEnter Arrow Head Selection, options are (S)teel, (W)ood, or (O)bsidian:  ");
                string input = Console.ReadLine().Trim().ToUpper();
                switch (input)
                {
                    case "S":   
                        return Head.Steel;
                    case "W":
                        return Head.Wood;
                    case "O":
                        return Head.Obsidian;
                    default:
                        Console.WriteLine($"Invalid Selection. Must be {Head.Steel}, {Head.Wood}, or {Head.Obsidian}.\n");
                        break;
                }
            }
        }
        public static Fletch FletchSelect()
        {
            while (true)
            {
                Console.Write($"\nEnter Fletch Selection, options are (P)lastic, (T)urkey Feathers, or (G)oose Feathers:  ");
                string input = Console.ReadLine().Trim().ToUpper();
                switch (input)
                {
                    case "P":   
                        return Fletch.Plastic;
                    case "T":   
                        return Fletch.Turkeyfeathers;
                    case "G":   
                        return Fletch.Goosefeathers;
                    default:
                        Console.WriteLine($"Invalid Selection. Must be (Plastic) (Turkey Feathers), or (Goose Feathers).\n");
                        break;
                }
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
                else Console.WriteLine($"Invalid Selection. Must be between {min}cm and {max}cm.\n");
            }
        }
        public static bool AddCheckOut()
        {
            Console.WriteLine("\n(A)dd Next Item or (C)heckout?");
            while (true)
            {
                Console.Write("Enter A or C: ");
                string input = Console.ReadLine().Trim().ToUpper();
                switch (input)
                {
                    case "A":   // Add Item
                        return true;
                    case "C":   // Check Out
                        return false;
                    default:
                        Console.WriteLine("Invalid Selection. Must be A, V, C");
                        break;
                }
            }
        }
        public static void Receipt(float total)
        {
            Console.WriteLine($"\nTotal Price : {total} gold.");
            Console.Write("Press any key to end.");
            Console.ReadKey();
        }
    }
}
