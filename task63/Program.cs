// задача 63. Вывести все натуральные числа в промежутке от 1 до N.

void PrintNumbers(int number)
{
    if(number == 0)
    {
        return;
    }
    PrintNumbers(number - 1);
    Console.Write(number + " ");
}

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumbers(N);