Random rand = new Random();
int randomNumber = 101;
int number = rand.Next(randomNumber);
int firstNumber = 3;
int lastNumber = 5;
int sum = 0;

for (int i = 0; i <= number; i++)
{
    if (i % firstNumber == 0 || i % lastNumber == 0) sum += i;
}

Console.WriteLine($"Число {number}");
Console.WriteLine($"Сумма положительных чисел меньше {number}, кратных {firstNumber} или {lastNumber}: {sum}");