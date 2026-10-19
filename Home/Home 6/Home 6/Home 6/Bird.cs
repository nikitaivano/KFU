public class Bird : General, IWalking, ISwim, IFly
{
    public void walk()
    {
        Console.WriteLine($"{name} ходит!");
    }

    public void swim()
    {
        Console.WriteLine($"{name} плавает!");
    }
    
    
    public void fly()
    {
        Console.WriteLine($"{name} летает!");
    }
    


    public override void register()
    {
        Console.WriteLine($"Зарегестрированный {name} с айди {ID}");
    }

    public Bird(int ID, string name, double intelligence, double strength, double agility) : base(ID, name, intelligence, strength, agility)
    {
        this.property = "У него есть маленький мозг, но умеет ходить, плавать, летать";
    }
    public override void printInfo()
    {
        Console.WriteLine($"ID:{ID}, Name:{name}, IQ:{intelligence}, Strength:{strength}, Agility:{agility}, \nОсобенность: {property}\n");
    }
}