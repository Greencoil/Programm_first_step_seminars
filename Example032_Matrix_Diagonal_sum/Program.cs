// Задайте двумерный массив. Найдите сумму элементов, находящихся на главнйо диагонали.
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

void DiagonalAmountNumbers(int[,] matr)
{
    int am = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                am = matr[i, j] + am;
            }
        }
    }
    Console.WriteLine("Сумма главной диагонали = " + am);
}

FillArray(array);
Console.WriteLine("Матрица: ");
PrintArray(array);
Console.WriteLine();
DiagonalAmountNumbers(array);
