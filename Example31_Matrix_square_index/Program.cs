// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты
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
Console.Write("Массив до возведеняи в квадрат: ");
Console.WriteLine();
PrintArray(array);

void PositivFindMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] % 2 == 0)
            {
                matr[i, j] = matr[i, j] * matr[i, j];
            }
        }
    }
}

PositivFindMatrix(array);
Console.WriteLine("Массив с возведением в квадрат: ");
PrintArray(array);

// Метод группы (не верное, потому что не все строчки находятся)
// void PositivFindMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i += 2)
//     {
//         for (int j = 0; j < matr.GetLength(1); j += 2)
//         {
//             matr[i, j] = matr[i, j] * matr[i, j];
//         }
//     }
// }