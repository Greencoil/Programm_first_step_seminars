int max = 0;
Console.WriteLine("Add number a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add number b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add number c = ");
int c = Convert.ToInt32(Console.ReadLine());

max = a;
if (max < b) max = b;
if (max < c) max = c;

Console.Write("The biggest number is = " + max);