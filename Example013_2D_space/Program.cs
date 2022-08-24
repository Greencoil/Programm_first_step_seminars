Console.WriteLine("Enter A cootdinates: ");
int ax = Convert.ToInt32(Console.ReadLine());
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B cootdinates: ");
int bx = Convert.ToInt32(Console.ReadLine());
int by = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));

Console.WriteLine(AB);