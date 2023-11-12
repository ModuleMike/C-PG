// Declare amount and tip percentage
decimal amount, tipPercentage;

Console.WriteLine("Tip Calculator");
Console.WriteLine("===============");

// Read user inputs
Console.Write("Enter amount: ");
amount = decimal.Parse(Console.ReadLine());

Console.Write("Enter tip: ");
tipPercentage = decimal.Parse(Console.ReadLine());

// Print final result
Console.WriteLine($"A {tipPercentage:p2} tip on {amount:c} is {(tipPercentage * amount):c}.");