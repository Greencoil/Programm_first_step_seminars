// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Enter your new number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your natural degree: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b > 0)
{
    int i = Convert.ToInt32(Math.Pow(a, b));
    Console.Write($"the construction is equal to: {i}");
}
else
{
    Console.Write("Please, enter natural degree");
}
