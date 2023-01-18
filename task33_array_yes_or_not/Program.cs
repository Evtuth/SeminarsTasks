// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

int[] array = new int[12];
array = FillArray(array);
Console.Write("Ваш массив: ");
Console.WriteLine(string.Join(", ", array));

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == a)
        {
            Console.WriteLine($"Число {a} присутствует в массиве!!!");
            break;
        }
        else
        {
            Console.WriteLine($"Число {a} не присутствует в массиве!!!");
            break;
        }
    }
    return;