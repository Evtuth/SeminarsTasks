

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

Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

int SumPositive = 0;
int SumNegative = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        SumPositive+=array[i];
    }
    else
    {
        SumNegative+=array[i];
    }
}

Console.WriteLine($"Сумма положительных чисел: {SumPositive}, а сумма отрицательных чисел: {SumNegative}");