// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

int[] ChangeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i] > 0)
        {
            array[i] = -array[i];
        }
        else
        {
            array[i] = array[i] - array[i]*2;
        }
    }
    return array;
}

int[] array = new int[12];
array = FillArray(array);
Console.Write("Ваш массив: ");
Console.WriteLine(string.Join(", ", array));

int[] arrayChange = new int[12];
arrayChange = ChangeArray(array);

Console.Write("Ваш измененный массив: ");
Console.WriteLine(string.Join(", ", arrayChange));

