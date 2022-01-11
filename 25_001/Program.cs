// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("ВВедите число, которое нужно возвести в степень: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень возведения: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
int result = NumberA;
for (int i = 1; i < NumberB; i++);
{
    result = result * NumberA;
}
Console.WriteLine($"Число {NumberA} в степени {NumberB} равно: {result}");