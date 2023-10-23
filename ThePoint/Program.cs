using ThePoint;

Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"({point1._X},{point1._Y})");
Console.WriteLine($"({point2._X},{point2._Y})");
Console.WriteLine(point1._X + point1._Y);
Console.WriteLine(point2);
point1 = new (point2._X , point2._Y);

Console.WriteLine($"({point1._X},{point1._Y})");
Console.WriteLine($"({point2._X},{point2._Y})");