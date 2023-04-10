Random rand = new Random();
int number = rand.Next(101);
int sum = 0;

for (int i = 0; i <= number; i++)
{
    if (i % 3 == 0 || i % 5 == 0) sum += i;
}

Console.WriteLine($"Число {number}");
Console.WriteLine($"Сумма положительных чисел меньше {number}, кратных 3 или 5 {sum}");