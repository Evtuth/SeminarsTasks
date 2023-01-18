// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 123);
    }
    return array;
}

int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 & array[i] <= 99)
        {
            sum += 1;
        }
    }
    return sum;
}

int[] array = new int[123];
array = FillArray(array);
Console.Write("Ваш массив: ");
Console.WriteLine(string.Join(", ", array));

int sum = SumArray(array);
Console.Write($"Количесвто элементов массива от 10 до 99 равно {sum} !!!");

