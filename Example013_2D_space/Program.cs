Console.WriteLine("Enter A cootdinates: ");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Enter B cootdinates: ");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));

Console.WriteLine(AB);