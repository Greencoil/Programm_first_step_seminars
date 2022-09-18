// Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Write("Введите размеры матрицы ");
int a = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, a];

void FillArraySpiral(int[,] matr)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= matr.GetLength(0) * matr.GetLength(1))
    {
        matr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matr.GetLength(1) - 1)
            j--;
        else
            i--;
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

FillArraySpiral(array);
Console.WriteLine("Матрица заполненная по спирали: ");
PrintArray(array);