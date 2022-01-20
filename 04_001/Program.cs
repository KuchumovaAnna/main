// 4. Найти максимальное из трех чисел

int NumberA = 710;
int NumberB = 685;
int NumberC = 862;
int max = NumberA;

if (NumberB > max) max = NumberB;

if (NumberC > max) max = NumberC;


Console.WriteLine(max);
