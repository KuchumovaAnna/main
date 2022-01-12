// лекция 2. макс из 9 чисел с помощью функции

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 22;
int b1 = 12;
int c1 = 56;
int a2 = 96;
int b2 = 42;
int c2 = 166;
int a3 = 82;
int b3 = 62;
int c3 = 32;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);