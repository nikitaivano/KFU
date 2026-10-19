public class Human : General, IWalking, ISwim, ISpeak
{
    public double walkingSpeed;

    public void walk()
    {
        Console.WriteLine($"{name} ходит!");
    }

    public void swim()
    {
        Console.WriteLine($"{name} плавает!");
    }

    public void speak()
    {
        Console.WriteLine($"{name} говорит!");
    }

    public override void register()
    {
        Console.WriteLine($"Зарегестрированный {name} с айди {ID}");
    }

    public Human(int ID, string name, double intelligence, double strength, double agility, double walkingSpeed) : base(ID, name, intelligence, strength, agility)
    {
        this.walkingSpeed = walkingSpeed;
        this.property = "У него есть наверное мозг, умеет ходить, плавать, говорит";
    }
    public override void printInfo()
    {
        Console.WriteLine($"ID:{ID}, Name:{name}, IQ:{intelligence}, Strength:{strength}, Agility:{agility}, Speed:{walkingSpeed}, \nОсобенность: {property}\n");
    }
}