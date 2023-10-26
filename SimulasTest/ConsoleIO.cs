namespace SimulasTest
{
    public class ConsoleIO
    {
        public static string Prompt(Chest status)
        {
            switch (status)
            {
                case (Chest)0:
                    return "opened";
                case (Chest)1:
                    return "closed";
                case (Chest)2:
                    return "locked";
                case (Chest)3:
                    return "unlocked";
                default:
                    return "error";
            }
        }
        public static Chest ChestRequest(string prompt, Chest status)
        {
            while (true)
            {
                Console.Write(prompt);
                string response = Console.ReadLine();
                if (Enum.TryParse(response, out Chest newStatus))
                {
                    return (NewRequestCheck(status, newStatus));
                }
                else
                    Console.WriteLine("Invalid option.. Please choose between Open, Close, Lock and Unlock.");
            }
        }
        public static Chest NewRequestCheck(Chest status, Chest newStatus)
        {
            if (Container.NewStatusCheck(status, newStatus) == newStatus)
            {
                Console.WriteLine($"Success! The Chest has been {Prompt(newStatus)}.");
            }
            else
                Console.WriteLine($"You can not {newStatus} the chest because it is {Prompt(status)}. Try something different.");
            return Container.NewStatusCheck(status, newStatus);
        }
    }
}
