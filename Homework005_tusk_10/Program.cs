Console.WriteLine("Add new thee-digit number ");
int a = Convert.ToInt32(Console.ReadLine());

int b = (a % 100) / 10;

Console.WriteLine("Second-digit number is " + b);