// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
Random rand = new Random();
            
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(40);
    Console.WriteLine("Array element № " + (i + 1) +  " = " + array[i]);
}
