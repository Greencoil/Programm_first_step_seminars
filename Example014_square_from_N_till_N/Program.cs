// Console.WriteLine("Введите целое чило ");
// int a = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= Math.Abs(a))
// {
//     if (i == a)
//     {
//         Console.Write(i * i);
//     }
//     else
//     {
//         Console.Write($"{i * i}, ");
//     }
    
//     i ++;
// }

Console.WriteLine("Введите целое чило ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= Math.Abs(a))
{
    Console.Write(i * i);
    if (i < Math.Abs(a))
    {
        Console.Write(", ");
    }
        
    i ++;
}