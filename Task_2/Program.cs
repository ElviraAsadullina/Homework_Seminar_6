﻿Console.WriteLine("Введите координаты прямой А через Enter: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты прямой B через Enter: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double intersection_x = (b2 - b1) / (k1 - k2);
double intersection_y = k2 * intersection_x + b2;
Console.WriteLine(intersection_x);
Console.WriteLine(intersection_y);
