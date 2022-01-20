// Показать числа от -N до N

Console.WriteLine("Введите число N = ");
int a = Convert.ToInt32(Console.ReadLine());

int count = a*(-1);
while (count<=a)
{
    Console.WriteLine(count);
    count++;
}