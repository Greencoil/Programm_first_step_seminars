// Зайдайте значение N. Напишите программу, которая выведет все нарутральные числа в промежутке от 1 до N. (с помощью рекурсии)
Console.WriteLine("Введите число до которого необходимо вывести числа: ");
int n = Convert.ToInt32(Console.ReadLine());
void RecursionNumbers(int i)
{
    if (i == n)
    {
        Console.Write(i);
    }
    else
    {
        Console.Write(i);
        i++;
        RecursionNumbers(i);
    }
}
int j = 1;
RecursionNumbers(j);