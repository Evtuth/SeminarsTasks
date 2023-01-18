// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int[] array = new int[12];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(", ", array));
Console.WriteLine();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isOk = false;
for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        isOk = true;
        break;
    }
}
if (isOk)
{
    Console.Write($"Число {number} присутствует в массиве!!!");
}
else
{
    Console.Write($"Число {number} не присутствует в массиве!!!");
}