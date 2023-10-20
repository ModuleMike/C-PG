namespace SimulasSoup
{
    public class Order
    {
        public static void ReceiptMeal((BowlType _bowl, MeatVeggie _MeatOrVeggie, Spice _spice) meal)
        {
            
            Console.WriteLine($"\nYou have ordered {meal._bowl} with {meal._MeatOrVeggie} that is {meal._spice}.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
