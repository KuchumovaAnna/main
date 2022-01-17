Console.Write("Введите ваше имя ");

string GetUsername()
{
    return Console.ReadLine();
}

string username = GetUsername();
Console.Write("Привет, ");
Console.Write(username); 