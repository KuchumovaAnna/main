// 66. Показать натуральные числа от 1 до N, N задано

void showNaturalNumbers(int currentNumber, int N)
{
    if (currentNumber < N)
    {
        Console.Write($" {currentNumber}, ");
        showNaturalNumbers(currentNumber + 1, N);
    }
}
Console.WriteLine("Задайте N");
int N = Convert.ToInt32(Console.ReadLine());
showNaturalNumbers(1, N);
