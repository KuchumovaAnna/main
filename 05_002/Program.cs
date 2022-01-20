// 5. Написать программу вычисления значения функции y = f(a) = (1+1/a)^a

Console.WriteLine("Введите переменную a = ");
double a = Convert.ToDouble(Console.ReadLine());
double y = 0;
if (a == 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    y = Math.Pow((1 + 1 / a), a);
    Console.WriteLine(y);
}
