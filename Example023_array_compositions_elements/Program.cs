// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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
int [] array = new int [7];
FillArray(array);
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int i = 0;
int o = array.Length - 1;
Console.Write("Произведение элементов = ");
while (i < o)
{
    int a = array[i] * array [o];
    Console.Write($"{a} ");
    i++;
    o--;
}

// Решение группы:
// int[] array = new int[5];

// int length = array.Length;
// int index = 0;

// while(index < length)
// {
// array[index] = new Random().Next(0, 5);
// Console.Write($"{array[index]} ,");
// index++;


// }
// Console.WriteLine();
// for ( int i = 0; i <( (length / 2) + 1); i++)
// {
// Console.WriteLine();
// if (i != (length -i -1) )
// {
// Console.Write($"{ array[i] * array[length -i -1]} ,");

// }
// else
// {
// Console.WriteLine(array[i]);
// }

// }
// //Console.WriteLine();
