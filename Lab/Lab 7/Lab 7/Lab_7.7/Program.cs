

int Fib(int n)
{   
    if (n <= 1) return n;
    else return Fib(n - 1) + Fib(n - 2);
}
Console.Write("Введите чилсо: ");
if (!int.TryParse(Console.ReadLine(), out int n))
{
    Console.WriteLine("Это не число");
    return;
}
int a1 = 0;
int a2 = 1;
int res = 0;

for (int i = 1; i < n; i++)
{
    int a3 = a1 + a2;
    a1 = a2;
    a2 = a3;
    res = a3;
    
}


Console.WriteLine(res);
