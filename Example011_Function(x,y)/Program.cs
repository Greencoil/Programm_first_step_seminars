Console.Write("Enter X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if(X > 0 && Y > 0)
{
    Console.WriteLine("1-st quarter");
}
if(X < 0 && Y > 0)
{
    Console.WriteLine("2-nd quarter");
}
if(X < 0 && Y < 0)
{
    Console.WriteLine("3-rd quarter");
}
if(X > 0 && Y < 0)
{
    Console.WriteLine("4-th quarter");
}