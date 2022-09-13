// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
Console.Clear();
Console.Write("Введите высоту матрицы ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину матрицы ");
int b = Convert.ToInt32(Console.ReadLine());

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
FillArray(array);
Console.WriteLine("Изначальная матрица: ");
PrintArray(array);
Console.WriteLine();

int[,] ChangeStringsColumns(int[,] matr)
{
    int[,] matr1 = new int[b, a];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr1[j, i] = matr[i, j];
        }
    }
    return matr1;
}
Console.WriteLine("Матрица в которой поменяли столбцы со строками: ");
PrintArray(ChangeStringsColumns(array));