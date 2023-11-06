

Console.WriteLine("The Following Items Are Available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.WriteLine("What is your name? ");

string name = Console.ReadLine();

Console.Write("What Number Do You Want To See The Price Of? ");
int choice = Convert.ToInt32(Console.ReadLine());

int rope = 10;
int torches = 16;
int canoe = 200;
int climbingEquipment = 26;
int cleanWater = 2;
int machete = 20;
int foodSupplies = 2;

if (name == "Mike")
{
    rope /= 2;
    torches /= 2;
    canoe /= 2;
    climbingEquipment /= 2;
    cleanWater /= 2;
    machete /= 2;
    foodSupplies /= 2;
}
    string response = choice switch
    {
        1 => $"Rope Cost {rope} Gold.",
        2 => $"Torches Cost {torches} Gold.",
        6 => $"Canoe Cost {canoe} Gold",
        3 => $"Climbing Equipment Cost {climbingEquipment} Gold",
        4 => $"Clean Water Cost {cleanWater} Gold.",
        5 => $"Machete Cost {machete} Gold.",
        7 => $"Food Supplies Cost {foodSupplies} Gold",
        _ => $"No Such Option Exists"
    };

    Console.WriteLine(response);