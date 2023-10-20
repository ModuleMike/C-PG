namespace SimulasSoup
{
    public class ConsoleIO
    {
        public static void Menu()
        {
            MenuBanner();
            MenuBowl();
            MenuMeatVeggie();
            MenuSpices();
            MenuFooter();
        }
        public static void MenuBanner()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"- - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine($"                 Simula's  Soups             ");
            Console.WriteLine($"- - - - - - - - - - - - - - - - - - - - - - -");
        }
        public static void MenuFooter()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"- - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine($"                                             ");
            Console.WriteLine($"- - - - - - - - - - - - - - - - - - - - - - -");
        }
        public static void MenuBowl()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nBowl Types  ---------------------------------");
            Console.WriteLine($"- {BowlType.gumbo}  - {BowlType.soup}  - {BowlType.stew}");
        }
        public static void MenuMeatVeggie()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nMeat / Veggies Types  -----------------------");
            Console.WriteLine($"- {MeatVeggie.potatoes}  - {MeatVeggie.mushrooms}"
            + $"  - {MeatVeggie.carrots}  - {MeatVeggie.chicken}");
        }
        public static void MenuSpices()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSpice Types  --------------------------------");
            Console.WriteLine($"-  {Spice.salty}  - {Spice.spicy}  - {Spice.sweet}");
        }
        public static BowlType BowlChoice()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nPick Bowl Type  -  ");
                string _input = Console.ReadLine();
                if (Enum.TryParse(_input, out BowlType _choice))
                {
                    return _choice;
                }
                Console.WriteLine($"Invalid Menu Option. The options between  {BowlType.gumbo}"
                    + $",  {BowlType.soup},  {BowlType.stew}.");
            }
        }
        public static MeatVeggie MeatVeggieChoice()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nPick Meat or Veggie  -  ");
                string _input = Console.ReadLine();
                if (Enum.TryParse(_input, out MeatVeggie _choice))
                {
                    return _choice;
                }
                Console.WriteLine($"Invalid Menu Option. The options between  {MeatVeggie.carrots}"
                   + $",  {MeatVeggie.potatoes},  {MeatVeggie.mushrooms},  {MeatVeggie.potatoes}"
                        + $",  {MeatVeggie.chicken}");
            }
        }
        public static Spice SpiceChoice()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nPick Spice Type  -  ");
                string _input = Console.ReadLine();
                if (Enum.TryParse(_input, out Spice _choice))
                {
                    return _choice;
                }
                Console.WriteLine($"Invalid Menu Option. The options between  {Spice.salty}" +
                    $",  {Spice.spicy},  {Spice.sweet}");
            }
        }
    }
}
