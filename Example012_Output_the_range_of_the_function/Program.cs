// Console.Write("Enter X: ");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter number from 1 till 4: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number <= 2)
// {
//     if(number < 2)
//     {
//         Console.WriteLine("x > 0; y > 0");
//     }
//     else
//     {
//        Console.WriteLine("x > 0; y < 0"); 
//     }

// }
// else
// {
//     if(number > 3)
//     {
//         Console.WriteLine("x > 0, y < 0");
//     }
//     else
//     {
//         Console.WriteLine("x < 0, y < 0");
//     }
// }

// Альтернативное решение с использование try/catch, Parse и объяснениями

Console.WriteLine("Введите номер четверти (от 1 до 4): ");
int count = 0;
while (count < 5)
{
    try
    {
        //  int x = Convert.ToInt32(Console.ReadLine())
        int x =Int32.Parse(Console.ReadLine());

        string [] q1 = {"x > 0 и y > 0", "x < 0 и y > 0", "x < 0 и y < 0", "x > 0 и y < 0" };
        Console.WriteLine("диапазон значений дял четверти " + x + " равен: " + q1 [x-1]);
        break;
    }
    catch
    {
        Console.WriteLine("От 1 до 4, пожалуйста ");
        Console.WriteLine();
        count++;
        if (count == 5)
        {
            Console.WriteLine("Ты исчерпал свои попытки");
        }
    }
    
}