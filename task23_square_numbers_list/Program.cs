// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int x = 0;

while (count <= N)
{
    x = count * count;
    Console.Write(x + " ");
    count++;
}