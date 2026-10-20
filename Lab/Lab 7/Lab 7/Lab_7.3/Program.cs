


Console.Write("Введите целое число: "); 
if (!int.TryParse(Console.ReadLine(), out int n)) 
{
    Console.WriteLine("Некорректный ввод."); 
    return; 
}

bool by3 = n % 3 == 0; 
bool by5 = n % 5 == 0; 

if (by3 && by5) 
    Console.WriteLine("Делится на 3 и на 5."); 
else
    Console.WriteLine("Не делится одновременно на 3 и на 5."); 