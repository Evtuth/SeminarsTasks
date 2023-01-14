//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int[] FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

int[] biarray = new int[8];
biarray = FillArray(biarray);

for(int i = 0; i < biarray.Length; i++)
    {
        Console.Write(biarray[i] + " ");
    }
