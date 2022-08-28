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

int [] array = new int [5];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] = - array[i];
}
PrintArray(array);