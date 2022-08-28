// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное числло в массиве
int[] array = new int[5];
int len = array.Length;
Console.Write("Enter number for chek ");
int a = Convert.ToInt32(Console.ReadLine());
int index = 0;

while (index < len)
{
    array[index] = new Random().Next(10);
    index++;
}

for (int i = 0; i < len; i++)
{
    Console.Write(array[i] + " ");
    if (array[i] == a)
    {
        Console.WriteLine($"Yes, yes number {a} is here");
    }
    else
    {
        Console.WriteLine($"No, no number {a} is not here");
    }
}
