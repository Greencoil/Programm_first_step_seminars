int n = new Random().Next(100, 1000);

Console.WriteLine("Three-digit number is " + n);

int FirstDigit = n / 100;
int ThirdDigit = n % 10;

int b = 10 * FirstDigit + ThirdDigit;

Console.WriteLine("Two-digit number is " + b);