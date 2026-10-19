public class MagicBall : General, IFly
{
    public void fly()
    {
        Console.WriteLine($"{name} летает!");
    }

    public override void register()
    {
        Console.WriteLine($"Зарегестрированный {name} с айди {ID}");
    }

    public MagicBall(int ID, string name, double intelligence, double strength, double agility) : base(ID, name, intelligence, strength, agility)
    {
        this.property = "Он волшебный шар";
    }
    public override void printInfo()
    {
        Console.WriteLine($"ID:{ID}, Name:{name}, IQ:{intelligence}, Strength:{strength}, Agility:{agility}, \nОсобенность: {property}\n");
    }
}