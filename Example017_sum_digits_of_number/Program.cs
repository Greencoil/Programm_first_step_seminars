// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
Console.Write("Enter new number: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (int i = 1; i <= a; i++)
{
    count = count * i;
}
Console.WriteLine(count);

