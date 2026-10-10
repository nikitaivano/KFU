class Balance
{
    public int balance;

    public void Add(int x)
    {
        balance += x;
    }

    public void Sub(int x)
    {
        if (x > balance)
        {
            Console.WriteLine("Нельзя");
        }    
        else
        {
            balance -= x;
            Console.WriteLine($"новый баланс {balance}");
        }
    }
}
