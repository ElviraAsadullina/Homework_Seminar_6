Console.WriteLine("Введите координаты прямой А через Enter: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты прямой B через Enter: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
if(b1 * k2 - b2 * k1 == 0)
{
    if(b1 * k2 == k1 * b2)
    {
        Console.WriteLine("Заданные прямые совпадают.");
        return;
    }
    Console.WriteLine("Заданные прямые параллельны.");
}
else
{
    double cross_x = (b2 - b1) / (k1 - k2);
    double cross_y = k2 * cross_x + b2;
    Console.WriteLine($"Координаты точки пересечения заданных прямых: х = {cross_x}, у = {cross_y}");
}