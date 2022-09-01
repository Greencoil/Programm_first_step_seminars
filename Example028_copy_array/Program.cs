// Напишите программу, которая будет создавать копию заданног омассива с помощью поэлементного копирования

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

void FillArray (int[] arr)
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

int[] Array = new int[length];
FillArray(Array);
Console.Write("Массив: ");
PrintArray(Array);
Console.WriteLine();
Console.WriteLine();

int[] ArrayCopy(int[] Array)
{
    int[] Array2 = new int[length];
    for(int i = 0; i < length; i++)
    {
        Array2[i] = Array[i];
    }
    return Array2;
}
Console.Write("Копия массива: ");
PrintArray(ArrayCopy(Array));
