// Принимает некое чило и прописывает сумму чисел от 1 до N

Console.WriteLine("Enter new number: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= a; i++)
{
    sum = sum + i;
}
Console.WriteLine($"{sum}");

