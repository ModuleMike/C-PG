using System.ComponentModel;
using VinFletchersArrows;

float total = 0;
bool addCheckOut = true;

while (addCheckOut)
{
    Console.Clear();
    if (ConsoleIO.CustomOrPremade())
    {   // Premade Order

        (Head head, Fletch fletch, float length) = Arrow.PremadeOrder(ConsoleIO.SelectPremade());
        total += Arrow.CheckOut(head, fletch, length);
    }
    else
    {   // Custom Order
        (Head head, Fletch fletch, float length) = Arrow.CustomOrder();
        total += Arrow.CheckOut(head, fletch, length);
    }
    addCheckOut = ConsoleIO.AddCheckOut();
}
ConsoleIO.Receipt(total);