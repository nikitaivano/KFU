Console.Write("Напиши строку: ");
string a = Console.ReadLine();

a = a.ToLower();
int c = 0;

foreach (char s in a)
{
    if (s == 'а' || s == 'е' || s == 'ё' || s == 'и' || s == 'о' || s == 'у' || s == 'ы' || s == 'э' || s == 'ю' || s == 'я')
    {
        c++;
    }    
}

Console.WriteLine($"В строке {c} гласных");