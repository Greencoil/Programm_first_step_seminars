// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Console.Clear();
Console.Write("Введите высоту матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение в матрице: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, b];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, c);
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

void FrequencyDictionary(int[,] matr)
{
    for (int n = 0; n <= c; n++)
    {
        int count = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (n == matr[i, j])
                {
                    count++;
                }
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"В матрице число {n} встречается {count} раз(а)");
        }
    }
}

Console.WriteLine("Частотный словарь: ");
FrequencyDictionary(array);