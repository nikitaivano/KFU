Console.Write("Введите целое п: "); 
if (!int.TryParse(Console.ReadLine(), out int n)) 
{
    Console.WriteLine("Нужно целое число."); 
    return; 
}

int result = Math.Abs(n - 48); 
if (n > 48) 
    result *= 3; 

Console.WriteLine($"Результат: {result}"); 