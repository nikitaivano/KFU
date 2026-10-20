string base2(int a)
{
    if (a < 2) return a.ToString();
    else return base2(a / 2) + (a % 2);
}


Console.Write("Введите чилсо: ");
if (!int.TryParse(Console.ReadLine(), out int a))
{
    Console.WriteLine("Это не число");
    return;
}

Console.WriteLine(base2(a));