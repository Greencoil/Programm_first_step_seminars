// Console.WriteLine("Enter a five-digit number: ");
// try
// {
// int a = int.Parse(Console.ReadLine());
// string str = a.ToString();
// int strLength = str.Length;
// if (str.Length == 5)
// {

//     if ((str[0] == str[4]) & (str[1] == str[3]))
//     {
//         Console.WriteLine("YES, this number is a palindrome");
//     }
//     else
//     {
//         Console.WriteLine("NO, this number is not a palindrome");
//     }
// }
// else
// {
//     Console.WriteLine("It is not a five-digit number, try another");
// }
// }
// catch
// {
// Console.WriteLine("It is not a number");
// }


// Console.Write("Enter 8 numbers: ");
// int a = Convert.ToInt32(Console.ReadLine());
// string s = a.ToString();
// int[] array = new int[s.Length];

// Console.Write(array[1]);

Console.Write("Enter new number: ");
int a = Convert.ToInt32(Console.ReadLine());
int c = 0;
string s = a.ToString();
int b = 0;
for (int i = 0; i < s.Length; i++)
{
    b = int.Parse(s[i].ToString());
    c = b + c;
}
Console.Write("The amount is: " + c);
