// Найти сумму чисел от 1 до А

Console.WriteLine("Введите число: ");
long number = Convert.ToInt32(Console.ReadLine());
DateTime dt = DateTime.Now; //текущее время
long Sum = 0;
// for (long i = 1; i <= number; i++)
// {
//     Sum = Sum + i;
// }
Sum = number * (number + 1) / 2;
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine(Sum);