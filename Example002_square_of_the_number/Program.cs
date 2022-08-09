Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("УРА УРА ЭТО КВАДРАТ!");
}
else
{
    Console.WriteLine("НУ НЕТ ТУТ КВАДРАТА!");       
}