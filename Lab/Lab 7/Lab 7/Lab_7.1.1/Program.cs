
Console.Write("Напиши строку: ");
string a = Console.ReadLine();

Console.Write("Напиши индекс который надо удалить: ");
if (!int.TryParse(Console.ReadLine(), out int b))
{
    Console.WriteLine("Некорректный ввод.");
    return;
}

if (b < a.Length && b > -1)
{
   a =a.Remove(b, 1);
   Console.WriteLine(a);
}
else Console.WriteLine("строка без изменений", a);

