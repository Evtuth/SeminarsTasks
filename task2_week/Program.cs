// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a == 1)
{
    Console.WriteLine("Ваш день: Понедельник");
}
else
{
    if(a == 2)
    {
       Console.WriteLine("Ваш день: Вторник"); 
    }
    else
    {
        if(a == 3)
        {
            Console.WriteLine("Ваш день: Среда"); 
        }
        else
        {
            if(a == 4)
            {
                Console.WriteLine("Ваш день: Четверг"); 
            }
            else
            {
                if(a == 5)
                {
                    Console.WriteLine("Ваш день: Пятница"); 
                }
                else
                {
                    if(a == 6)
                    {
                        Console.WriteLine("Ваш день: Суббота"); 
                    }
                    else
                    {
                        if(a == 7)
                        {
                            Console.WriteLine("Ваш день: Воскресенье"); 
                        }
                        else
                        {
                            Console.WriteLine("Число введено некоректно!!!"); 
                        }
                    }
                }
            }
        }
    }
}