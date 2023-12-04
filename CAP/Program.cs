int menuNum;
string[] lockers = new string[100];
string keyOut = "";
string keyIn = "";

do
{
    Console.WriteLine("Airport Locker Rental Menu");
    Console.WriteLine("=============================");
    Console.WriteLine("1. View a locker ");
    Console.WriteLine("2. Rent a locker");
    Console.WriteLine("3. End a locker rental");
    Console.WriteLine("4. List all locker contents");
    Console.WriteLine("5. Quit\n");

    do
    {
        keyIn = "IN";
        Console.Write("Enter your choice (1-5): ");
        if (int.TryParse(Console.ReadLine(), out menuNum) && menuNum > 0 && menuNum < 6)
        {
            switch (menuNum)
            {
                case 1: // View Locker
                    do
                    {
                        Console.Write("Enter locker number (1-100): ");
                        if (int.TryParse(Console.ReadLine(), out menuNum) && menuNum <= 100 && menuNum > 0)
                        {
                            if (lockers[menuNum + 1] != null)
                            {
                                Console.WriteLine($"Locker {menuNum} contents: {lockers[menuNum +1]}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Locker {menuNum} is EMPTY.");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 100.");
                        }                       
                    } while (true);

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    keyIn = "OUT";
                    break;

                case 2: // Rent Locker
                    do
                    {
                        Console.Write("Enter locker number (1-100): ");
                        if (int.TryParse(Console.ReadLine(), out menuNum) && menuNum <= 100 && menuNum > 0)
                        {
                            if (lockers[menuNum + 1] == null)
                            {
                                Console.Write("Enter the item you want to store in the locker: ");
                                lockers[menuNum + 1] = Console.ReadLine();
                                Console.WriteLine($"Locker {menuNum} has been rented for {lockers[menuNum + 1]} storage.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Sorry, but locker {menuNum} has already been rented!");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 100.");
                        }
                    } while (true);
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    keyIn = "OUT";
                    break;

                case 3:  // End Locker Rental
                    do
                    {
                        Console.Write("Enter locker number (1-100): ");
                        if (int.TryParse(Console.ReadLine(), out menuNum) && menuNum <= 100 && menuNum > 0)
                        {
                            if (lockers[menuNum + 1] != null)
                            {
                                Console.WriteLine($"Locker {menuNum} rental has ended, please take your {lockers[menuNum + 1]}.");
                                lockers[menuNum + 1] = null;
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Locker {menuNum} is not currently rented.");
                                break;
                            }
                        }
                    } while (true);
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    keyIn = "OUT";
                    break;

                case 4: // List All Locker Contents
                    for (int i = 0; i < lockers.Length; i++)
                    {
                        if (lockers[i] != null)
                        {
                            Console.WriteLine($"Locker {i + 1}: {lockers[i]}");
                        }
                    }
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    keyIn = "OUT";
                    break;

                case 5:  // Quit
                    keyIn = "OUT";
                    keyOut = "OUT";
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
        }

    } while (keyIn != "OUT");

} while (keyOut != "OUT");