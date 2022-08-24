Console.Write("Enter 8 numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
string s = a.ToString();
int[] b = new int[s.Length];
int c = 0;
if (s.Length == 8)
{
    while (c < s.Length)
    {
        Console.Write($"{s[c]},");
        c++;
    }
    
    Console.Write($"{s[7]}");

}
if (s.Length < 8)
{
    Console.WriteLine("No, no, no (<)");
}
if (s.Length > 8)
{
    Console.WriteLine("No, no, no (>)");
}