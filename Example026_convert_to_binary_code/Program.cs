// Напишите программу, программу которая преобразует десятичное число в двоичное.

int a = new Random().Next(0, 100);

void ToBin(int a)
{
    if (a > 1)
    {
        ToBin(a / 2);
        Console.WriteLine(a % 2);
    }
    else
    {
        Console.Write(a % 2);
    }
}
Console.WriteLine("Ваше число - " + a);
Console.WriteLine();
Console.Write("Ваше число в двоичной системе счисления - ");
ToBin(a);