// Напишите прогрраму, которая принимает на вход число и выдаёт количество цифр в числе

// Моё решение:
Console.WriteLine("Enter new number: ");
int a = Convert.ToInt32(Console.ReadLine());
string str = a.ToString();
int strLength = str.Length;
int sum = 0;
Console.WriteLine($"Колличество цифр: {sum = sum + str.Length}");



// Решение группы:
// Console.WriteLine("введите целое число больше 0 ");
// int a = int.Parse(Console.ReadLine());
// int length = 0;
// if (a % 10 == 0)
// {
//     Console.WriteLine("число однозначное");
// }
// else
// {
//     while (Math.Abs(a) % 10 > 1)
//     {
//         a = a / 10;
//         length++;
//         Console.WriteLine(length);
//     }
//     Console.WriteLine($"в числе {length} цифры");
// }





// Решение преподавателя:
// Console.WriteLine("введите целое число больше 0 ");

// int a = Convert.ToInt32(Console.ReadLine());

// int count = 0;

// while (a != 0)
// {
//     a = a / 10;
//     count++;    
// }
// Console.WriteLine(count);