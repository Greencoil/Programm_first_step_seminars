// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые числа Фибоначчи: 0 и 1.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int [] Fibonacci = new int[a];
Fibonacci[0] = 0;
Fibonacci[1] = 1;

for(int i = 2; i < a; i++)
{
    Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
}
void PrintArray (int [] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{arr [i]} ");
    }
}
Console.Write("Числа Фибоначчи из заданного: ");
PrintArray(Fibonacci);