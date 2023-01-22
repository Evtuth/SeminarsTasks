// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int[] FillArray(int[] array)
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Введите сторону треугольника: ");
        int A = Convert.ToInt32(Console.ReadLine());
        array[i] = A;
    }
    return array;
}



int[] triangle = new int[3];
triangle = FillArray(triangle);
Console.Write("Стороны ваше треугольника: ");
Console.WriteLine(string.Join(", ", triangle));
if (triangle[0] + triangle[1] > triangle[2] & triangle[2] + triangle[1] > triangle[0] & triangle[0] + triangle[2] > triangle[1])
{
    Console.Write("Треугольник с такими сторонами может существовать!!!");
}
else
{
    Console.Write("Треугольник с такими сторонами не может существовать!!!");
}


