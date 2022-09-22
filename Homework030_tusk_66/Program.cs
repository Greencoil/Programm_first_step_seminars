// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N (используйте рекурсию).
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите последнее число: ");
int b = Convert.ToInt32(Console.ReadLine());

int RecursionAmountNumbers(int a, int b)
{
    if (a == b)
    {
        return a;
    }
    else
    {
        return RecursionAmountNumbers(a + 1, b) + a;
    }
}
Console.WriteLine();
Console.Write($"Сумма числе от {a} до {b} равна: " + (RecursionAmountNumbers(a, b)));

