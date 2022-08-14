Console.WriteLine("Add new number a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add new number b = ");
int b = Convert.ToInt32(Console.ReadLine());

if ((a == b * b) ^ (b == a * a))
{
    Console.WriteLine("Yes, this is a square");
}
else
{
    Console.WriteLine("No, this is not a square");
}