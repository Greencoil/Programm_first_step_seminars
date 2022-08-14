int n = new Random().Next(10, 100);

Console.WriteLine("Rndom number from 10 to 99 " + n);

int FirstDigit = n / 10;
int SecondDigit = n % 10;

if (FirstDigit > SecondDigit)
{
    Console.WriteLine("Maximum number is " + FirstDigit);
}
else
{
    Console.WriteLine("Maximum number is " + SecondDigit);
}

