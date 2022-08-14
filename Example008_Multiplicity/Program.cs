Console.WriteLine("Add new number a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add new number b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a / b == 0)
{
    Console.WriteLine("Multiple");
}
else
{
    Console.WriteLine("Remains " + a / b );
}