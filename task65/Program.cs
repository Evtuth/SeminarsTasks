// задача 65. Вывести все натуральные числа в промежутке от M до N.

void PrintNumbers(int M, int N)
{
    if (N == M-1)
    {
        return;
    }
    PrintNumbers(M, N - 1);
    Console.Write(N + " ");
}

Console.WriteLine("Введите первое число:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumbers(M, N);