// задача 67. Натйти сумму цифр в числе

int Sum(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number%10 + Sum(number/10);
}

Console.WriteLine("Введите число:");
int M = Convert.ToInt32(Console.ReadLine());
int sum = Sum(M);
Console.WriteLine(sum);