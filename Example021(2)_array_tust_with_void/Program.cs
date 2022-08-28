void FillArray (int [] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr [i] = new Random().Next(-100, 100);
    }
}

void PrintArray (int [] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{arr [i]} ");
    }

}

int [] array = new int [8];
FillArray(array);

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int var = 0;
for (int i = 0; i < array.Length; i++)
{
    if (a == array[i])
    {
        Console.WriteLine($"Заданное число |{a}| присутствует в массиве");
        var++;
        break;
    }
}

if (var == 0)
{
    Console.WriteLine($"Заданное число |{a}| отсутствует в массиве");
}
PrintArray(array);