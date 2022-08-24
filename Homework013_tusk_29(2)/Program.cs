Console.Write("Enter 8 numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
string s = a.ToString();
int[] b = new int[s.Length];
int c = 0;
if (s.Length == 8)
{
    while (c < s.Length - 1)
    {
        Console.Write($"{s[c]},");
        c++;
    }
    
    Console.Write($"{s[7]}");

}
if (s.Length < 8)
{
    Console.WriteLine("No, no, no < numbers");
}
if (s.Length > 8)
{
    Console.WriteLine("No, no, no > numbers");
}