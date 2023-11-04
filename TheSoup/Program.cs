Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Clear();
Console.Title = "Defense of Consolas.";
Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());


Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Clear();

string team1 = $"Team One - {targetRow + 1}, {targetColumn}!";
string team2 = $"Team Two - {targetRow}, {targetColumn - 1}!";
string team3 = $"Team Three - {targetRow - 1}, {targetColumn}!";
string team4 = $"Team Four - {targetRow}, {targetColumn + 1}!";

Console.Write($"Deploy To:\n" +
    $"{team1}\n" +
    $"{team2}\n" +
    $"{team3}\n" +
    $"{team4}\n");

Console.Beep(340, 1000);