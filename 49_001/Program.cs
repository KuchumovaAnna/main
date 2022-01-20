// 49. Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("Введите N");
int N = Convert.ToInt32(ReadLine());
Console.WriteLine("Введите M");
int M = Convert.ToInt32(ReadLine());

double[,] Array = new double[M, N];
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Array[i, j] = new Random().NextDouble(-10, 10);
    }
}
