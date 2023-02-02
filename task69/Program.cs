// задача 67. Написать программу, которая принимает два числа и возводит первое число в степень второго числа.

int Square(int A, int B)
{
    int count = 1;
    if (B == 0)
    {
        return count;
    }
    else
    {
        return count = A*Square(A, B-1);
    }

}

Console.WriteLine("Введите первое число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());
int exp = Square(A, B);
Console.WriteLine(exp);