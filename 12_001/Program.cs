// 12. Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int result1 = number % 10;
System.Console.WriteLine(result1);
int result2 = (number % 1000)/100;
Console.WriteLine(result2);
System.Console.WriteLine("После удаления второй цифры числа получится: " + result2 + result1);