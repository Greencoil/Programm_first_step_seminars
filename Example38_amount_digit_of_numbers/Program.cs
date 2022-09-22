// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.WriteLine("Введите двухзначное или более значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int RecursionAmountDigit(int a)
{
    if (a == 0)
    {
        return 0;
    }
    else
    {
        return RecursionAmountDigit(a / 10) + a % 10;
    }
}
Console.WriteLine(RecursionAmountDigit(a));
