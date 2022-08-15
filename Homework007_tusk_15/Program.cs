Console.Write("Enter the number of the day of the week ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 6 ^ a == 7)
{
    Console.WriteLine("Yes, it's a day off");
}
else
{
    Console.WriteLine("No, it is work day");
}