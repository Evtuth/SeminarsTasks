// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] FillArray(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-2]+array[i-1];
    }
    return array;
}

Console.WriteLine("Введите количество чисел Фибоначи, которые вы хотите увидеть: ");
int FibonachiNumber = Convert.ToInt32(Console.ReadLine());
int[] ArrayFibonachi  = new int[FibonachiNumber];
FillArray(ArrayFibonachi);
Console.Write("Ваш ряд чисел Фибоначи: ");
Console.WriteLine(string.Join(", ", ArrayFibonachi));