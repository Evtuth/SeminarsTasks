// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите значение четверти: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb == 1)
{
    Console.WriteLine("X > 0, Y > 0");
}
else if (numb == 2)
{
    Console.WriteLine("X < 0, Y > 0");
}
else if (numb == 3)
{
    Console.WriteLine("X < 0, Y < 0");
}
else if (numb == 4)
{
    Console.WriteLine("X > 0, Y < 0");
}
else if (numb <= 0 || numb > 3)
{
    Console.WriteLine("Неверное число!");
}