// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99]

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
int [] array = new int [123];
FillArray(array);
PrintArray(array);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (9 < array[i] & array[i] < 100)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine();
Console.Write("Количество элементов в отрезе [10, 99] " + count);