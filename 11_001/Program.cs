// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10,100);
Console.WriteLine(number);
// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

int a = number % 10;
int b = number / 10;
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}