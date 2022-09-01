// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые числа Фибоначчи: 0 и 1.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int firstElem = 1;
int secondElem = 1;

Console.WriteLine("Последовательность Фибоначчи: ");
Console.WriteLine("0. 0");
Console.WriteLine($"1. {firstElem}");
Console.WriteLine($"2. {secondElem}");

for (int i = 3; i <= a; i++)
{
    int nextElem = firstElem + secondElem;
    Console.WriteLine($"{i}. {nextElem}");
    firstElem = secondElem;
    secondElem = nextElem;
}