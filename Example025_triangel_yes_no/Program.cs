// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
Console.Write("Введите 1 число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите 3 число: ");
int c = int.Parse(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Да, может быть такой треугольник");
}
else
{
    Console.WriteLine("Нет такого треугольника быть не может");    
}