Console.WriteLine("Add new number ");
int a = Convert.ToInt32(Console.ReadLine());

while (a > 999)
{
   a = a / 10;
}
if (a > 99)
{
   int b = a % 10;
   Console.WriteLine("There is three-digit number " + b);
} 
else
{
   Console.WriteLine("It is not three-digit number");
}
