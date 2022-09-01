// Напишите программу, которая переврнёт одномерный массив (последний элемент будет на первом месте, а первый на последнем)
// Решение с использованием методов:
void FillArray (int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
}
int[] ReverseArray(int[] arr)
{
    int[] result = new int[arr.Length];

    for (int i = 0, j = arr.Length -1; i < arr.Length; i++, j--)
    {
        result[i] = arr[j];
    }
    return result;
}
void PrintArray (int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] arr = new int[5];
FillArray(arr);
var result = ReverseArray(arr);
Console.Write("Развернутый массив: "); 
PrintArray(result);
Console.WriteLine();
Console.WriteLine();
Console.Write("Массив: ");
PrintArray(arr);
