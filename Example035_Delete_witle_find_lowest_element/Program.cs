// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Console.Clear();
Console.Write("Введите высоту матрицы ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину матрицы ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, b];
int Imin = 0;
int Jmin = 0;

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

void FindMinElement(int[,] matr, out int row, out int col)
{
    int min = matr[0, 0];
    col = 0;
    row = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                row = i;
                col = j;
            }
        }

    }
    Console.Write("Минимальное значение: " + min);
}

FindMinElement(array, out Imin, out Jmin);
Console.WriteLine();
Console.Write("Строка минимального(i): " + Imin);
Console.WriteLine();
Console.Write("Столбец минимального(j): " + Jmin);
Console.WriteLine();

int[,] CutMatrix(int[,] matr, int row, int col)
{
    int[,] matr1 = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int fildI = 0;
    int fildJ = 0;
    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            if (i < row) fildI = 0;
            else fildI = 1;
            if (j < col) fildJ = 0;
            else fildJ = 1;
            matr1[i, j] = matr[i + fildI, j + fildJ];
        }
    }
    return matr1;
}
Console.WriteLine();
Console.WriteLine("Матрица без строки столбца минимального значения:");
PrintArray(CutMatrix(array, Imin, Jmin));