int[] originalArray = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Enter a number: ");
    originalArray[i] = Convert.ToInt32(Console.ReadLine());
}

int[] newArray = new int[5];
for (int j = 0; j < 5; j++)
    newArray[j] = originalArray[j];

for (int c = 0; c < 5; c++)
    Console.WriteLine($"Original List : {originalArray[c]} | New Array : {newArray[c]}");


// For Each Loops

int[] array1 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue;

foreach (int i in array1)
{
    if (i < currentSmallest)
        currentSmallest = i;
}
Console.WriteLine(currentSmallest);


// Practice 2

int[] array2 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int totalNum = 0;

foreach (int j in array2)
{
    totalNum += j;
}

float average = (float)totalNum / array2.Length;

Console.WriteLine($"{average:.00}");