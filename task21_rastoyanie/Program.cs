// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату Хa: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Ya: ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Хb: ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Yb: ");
int Yb = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(((Xb - Xa)*(Xb - Xa)) + ((Yb - Ya)*(Yb - Ya)));

Console.Write("Расстояние равно: " + Math.Round(d, 2));