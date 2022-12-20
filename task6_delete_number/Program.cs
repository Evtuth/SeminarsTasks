// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Ваше случайное число: {number}");

int digit1 = number % 10;
int digit2 = number / 100;

Console.WriteLine($"Ваше число: {digit2}{digit1}");
