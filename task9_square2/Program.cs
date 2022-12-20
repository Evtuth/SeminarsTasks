// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int min = 0;
int max = 0;

if( a > b)
{
    min = b;
    max = a;
}
else
{
    min = a;
    max = b;
}

int square = min*min;

if(square == max)
{
    Console.WriteLine("Число " + max + " является квадратом числа " + min);
}
else
{
   Console.WriteLine("Число " + max + " не является квадратом числа " + min); 
}