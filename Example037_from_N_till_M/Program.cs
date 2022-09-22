// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Введите число от которого необходимо вывести числа: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число до которого необходимо вывести числа: ");
int b = Convert.ToInt32(Console.ReadLine());
void RecursionNumbers(int i)
{
    if (i == b)
    {
        Console.Write($" {i} ");
    }
    else
    {
        Console.Write($" {i} ");
        i++;
        RecursionNumbers(i);
    }
}

RecursionNumbers(a);