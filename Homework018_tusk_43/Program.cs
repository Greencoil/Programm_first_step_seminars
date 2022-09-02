// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Enter a1: ");
double a1 = int.Parse(Console.ReadLine());

Console.Write("Enter b1: ");
double b1 = int.Parse(Console.ReadLine());

Console.Write("Enter a2: ");
double a2 = int.Parse(Console.ReadLine());

Console.Write("Enter b2: ");
double b2 = int.Parse(Console.ReadLine());

Console.Write($"Points: a1 = {a1}, b1 = {b1}, a2 = {a2}, b2 = {b2}");

double x = (b2 - b1) / (a1 - a2);
double y = a1 * x + b1;

Console.WriteLine();
Console.WriteLine();

Console.Write($"Coordinates: x = {x}, y = {y}");