//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

int Prod(int number)
{
    int prod = 0;
    if (number == 0)
    {
        prod = 0;
    }
    else
    {
        prod = 1;
        for (int i = 1; i <= number; i++)
        {
            prod = prod * i;
        }
        
    }
    return prod;
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int prod = Prod(A);
Console.WriteLine("Произведение чисел: " + prod);