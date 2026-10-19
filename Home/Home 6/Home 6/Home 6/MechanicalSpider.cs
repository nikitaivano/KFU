public class MecSpider : General, IWalking
{
    public void walk()
    {
        Console.WriteLine($"{name} ходит!");
    }

    public override void register()
    {
        Console.WriteLine($"Зарегестрированный {name} с айди {ID}");
    }

    public MecSpider(int ID, string name, double intelligence, double strength, double agility) : base(ID, name, intelligence, strength, agility)
    {
        this.property = "Это механический паук! Скорее всего есть процессор и в разы опаснее обычного!";
    }
    public override void printInfo()
    {
        Console.WriteLine($"ID:{ID}, Name:{name}, IQ:{intelligence}, Strength:{strength}, Agility:{agility}, \nОсобенность: {property}\n");
    }
}