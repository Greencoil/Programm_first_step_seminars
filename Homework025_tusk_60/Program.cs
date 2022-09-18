// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
int[,,] arr = new int[2, 2, 2];
IEnumerable<int> UniqueRandomNumbers(int from, int to)
{
    Random rand = new();
    int[] values = Enumerable.Range(from, to).ToArray();
    int i = values.Length;
    while (i > 0)
    {
        int j = rand.Next(i--);
        yield return values[j];
        (values[i], values[j]) = (values[j], values[i]);
    }
}
IEnumerator<int> iterator = UniqueRandomNumbers(9, 100).GetEnumerator();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            if (!iterator.MoveNext())
            {
                Console.WriteLine("Упс, уникальные числа закончились!");
                return;
            }
            arr[i, j, k] = iterator.Current;
            Console.Write($"{arr[i, j, k]}: ({i}, {j}, {k}) ");
        }
        Console.WriteLine();
    }
}