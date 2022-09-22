// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1 (используйте рекурсию).
Console.Clear();
Console.Write("Введите число от которого которого необходимо вывести числа по убыванию: ");
int a = Convert.ToInt32(Console.ReadLine());
void RecursionNumbers(int a)
{
    if (a == 0)
    {
        Console.Write($"{a}.");
    }
    else
    {
        Console.Write($"{a}, ");
        RecursionNumbers(a - 1);
    }
}
Console.WriteLine();
Console.Write("Числа по убыванию: " + RecursionNumbers(a));