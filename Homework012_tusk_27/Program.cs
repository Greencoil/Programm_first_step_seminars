// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Enter new number: ");
int a = Convert.ToInt32(Console.ReadLine());
int c = 0;
string s = a.ToString();
int[] b = new int[s.Length];
for (int i = 0; i < s.Length; i++)
{
    b[i] = int.Parse(s[i].ToString());
    c = b[i] + c;
}
Console.Write("The amount is: " + c);
