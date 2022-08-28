// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray (int [] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr [i] = new Random().Next(1, 100);
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
int am = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    am = am + array[i];
}
Console.Write("Сумма: " + am);