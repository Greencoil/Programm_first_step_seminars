// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int RecursionAkkermanNum(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (b == 0 && a > 0)
    {
        return RecursionAkkermanNum(a - 1, 1);
    }
    else
    {
        return (RecursionAkkermanNum(a - 1, RecursionAkkermanNum(a, b - 1)));
    }
}
Console.WriteLine();
Console.Write($"От чисел {a} и {b} с помощью функции Аккермана возвращено: " + RecursionAkkermanNum(a, b));

