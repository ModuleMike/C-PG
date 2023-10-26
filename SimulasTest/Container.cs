namespace SimulasTest
{
    public class Container
    {
        public static Chest NewStatusCheck(Chest status, Chest newStatus)
        {
            if ((status == Chest.Open && newStatus == Chest.Close) ||
                (status == Chest.Close && newStatus == Chest.Lock) ||
                (status == Chest.Lock && newStatus == Chest.Unlock) ||
                (status == Chest.Unlock && newStatus == Chest.Open))
            {
                return newStatus;
            }
            else
                return status;
        }
        public static void SimulasTest()
        {
            Chest status = Chest.Open;
            while (true)
            {
                status = ConsoleIO.ChestRequest($"The chest is {ConsoleIO.Prompt(status)}. What do you want to do? ", status);
            }
        }
    }
}
