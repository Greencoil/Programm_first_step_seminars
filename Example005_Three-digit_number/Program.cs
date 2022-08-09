Console.Write("Введите трехзначное число ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 100 && N <= 999)
{
    int lastNumber = N % 10;
    Console.WriteLine("А вот и она, цифра твоя = " + lastNumber);
}
else
{
    Console.WriteLine("Неее, это не трехзначное число, запусти по новой!");
}