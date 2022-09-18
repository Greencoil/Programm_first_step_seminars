// Вывести первые N строк треугольника Паскаля.

Console.Clear();
int i, n, c;
Console.Write("Введите количество строк треугольника Паскаля: ");
string s = Console.ReadLine();
n = Convert.ToInt32(s);
Console.WriteLine("Ваш треугольник Паскаля: ");
Console.WriteLine();
Console.WriteLine();

static float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}
for (i = 0; i < n; i++)
{
    for (c = 0; c <= (n - i); c++) 
    {
        Console.Write(" ");
    }
    for (c = 0; c <= i; c++)
    {
        Console.Write(" "); 
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); 
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.ReadLine();