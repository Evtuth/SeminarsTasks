// Задача 45: Напишите программу, которая будет создавать копию заданного массива
//  с помощью поэлементного копирования.

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

int[] CopyArray(int[] array1, int[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array2[i] = array1[i];
    }
    return array2;
}

int[] array1 = new int[5];
array1 = FillArray(array1);
int[] array2 = new int[array1.Length];
array2 = CopyArray(array1, array2);

Console.Write("Ваш созданный массив: ");
Console.WriteLine(string.Join(", ", array1));
Console.Write("Ваш скопированный массив: ");
Console.WriteLine(string.Join(", ", array2));