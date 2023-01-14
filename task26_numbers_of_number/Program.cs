//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int Sum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        number = number/10;
        sum += 1;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = Sum(A);
Console.WriteLine("Количество знаков в вашем числе: " + sum);
