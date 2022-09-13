// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива
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

void ChangeStrings(int[,] matr)
{
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int temp = matr[0, j];
            matr[0, j] = matr[matr.GetLength(0) - 1, j];
            matr[matr.GetLength(0) - 1, j] = temp;
        }
    }
}
ChangeStrings(array);
Console.WriteLine("Матрица в которой поменяли строки: ");
PrintArray(array);