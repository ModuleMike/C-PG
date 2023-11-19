namespace SimulasSoup
{
    internal class App
    {
        public static void Run()
        {
            while (true)
            {
                ConsoleIO.Menu();
                (BowlType, MeatVeggie, Spice) orderMeal = (ConsoleIO.BowlChoice(), ConsoleIO.MeatVeggieChoice(), ConsoleIO.SpiceChoice());
                Order.ReceiptMeal(orderMeal);
                break;
            }
        }
    }
}
