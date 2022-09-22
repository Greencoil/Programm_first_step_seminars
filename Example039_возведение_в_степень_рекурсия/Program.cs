// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int RecursionSquareNum(int b, int a)
{
    if (b == 0)
    {
        return 1;
    }
    if (b == 1)
    {
        return a;
    }
    else
    {
        return a * RecursionSquareNum(b - 1, a);
    }
}
Console.Write(RecursionSquareNum(b, a));
