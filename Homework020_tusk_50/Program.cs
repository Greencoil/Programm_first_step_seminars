// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите высоту матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки: ");
int d = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, b];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();

if (c < 0 | c > array.GetLength(0) - 1 | d < 0 | d > array.GetLength(1) - 1)
{
    Console.WriteLine("Числа с заданными параметрами в данном массиве нет");
}
else
{
    Console.WriteLine("Число с заданными параметрами = {0}", array[c, d]);
}


