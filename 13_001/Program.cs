// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Для проверки кратности на число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 % number2;
int result1 = number1 - ((number1 / number2) * number2);

if (result == 0)
{
    Console.WriteLine("Введенное число {0} кратно {1}", number1, number2);
}
else
{
    Console.WriteLine("Введенное число {0} не кратно {1}", number1, number2);
    Console.WriteLine("Остаток от деления :" + result1);
}
