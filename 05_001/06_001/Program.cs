﻿// 6. Выяснить является ли число чётным

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("четное число");
}
else
{
    Console.WriteLine("нечетное");
}
