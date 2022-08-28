// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот.
// [-4, -4, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[4];
int len = array.Length;
int index = 0;
int result = 0;
while (index < len)
{
    array[index] = new Random().Next(-10, 10);
    index ++;
}
for (int i = 0; i < len; i++)
{
    result = array[i] * -1;
    Console.Write(array[i] + " ");
    Console.WriteLine(result + " ");
}
