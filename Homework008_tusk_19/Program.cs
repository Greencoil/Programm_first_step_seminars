Console.WriteLine("Enter five-digit number: ");
int a = int.Parse(Console.ReadLine());
string str = a.ToString();
int strLength = str.Length;

if (str.Length == 5)
{
    if ((str[0] == str[4]) & (str[1] == str[3]))
    {
        Console.WriteLine("YES, this number is polinom");
    }
    else
    {
        Console.WriteLine("NO, this number is not polinom");
    }
}
else
{
    Console.WriteLine("It is not five-digit number, try another");
}