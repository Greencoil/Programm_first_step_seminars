// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void PrintArray (int [] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{arr [i]} ");
    }
}
int [] array = {3, 7, 22, 2, 78};
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int am= 0;
int max = array[0];
int min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
for (int o = 1; o < array.Length; o++)
{
    if (array[o] < min)
    {
       min = array[o];
    }
}

am = max - min;
Console.Write("Разница: " + am);