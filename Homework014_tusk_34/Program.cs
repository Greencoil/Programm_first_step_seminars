// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray (int [] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr [i] = new Random().Next(100, 999);
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

int [] array = new int [6];
FillArray(array);
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    count++;
}
Console.Write("Количество положительных чисел: " + count);