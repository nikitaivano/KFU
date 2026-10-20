
Console.Write("Введите число >= 0: "); 
if (!int.TryParse(Console.ReadLine(), out int n) || n < 0) 
{
    Console.WriteLine("Введите неотрицательное целое число.");
    return; 
}

int sum = 0; 
int product = n == 0 ? 0 : 1; 
while (n > 0) 
{
    int digit = n % 10; 
    sum += digit; 
    product *= digit; 
    n /= 10; 
}
Console.WriteLine($"Сумма: {sum}, произведение: {product}"); 