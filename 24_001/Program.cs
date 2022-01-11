// Найти сумму чисел от 1 до А

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i =1; i <= number; i++)
{
    int result = i + i;
    Console.WriteLine(result);
}