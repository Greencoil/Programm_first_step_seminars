// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
PrintArray(array);

void AmountOfColumn(int[,] matr)
{
    
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double am = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            am += matr[i, j];
        }
        am = am / matr.GetLength(0);
        Console.Write("{0:0.00} ", am);
    }
}
Console.Write("Среднее арифметическое столбцов: ");
AmountOfColumn(array);