Console.Write("Add number a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Add number b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    int BiggestNumber = a;
    Console.WriteLine("a - is a winner!");
    Console.Write(BiggestNumber);
}
else
{
    int BiggestNumber = b;
    Console.WriteLine("b - is a winner!");
    Console.Write(BiggestNumber);
}