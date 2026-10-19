public class Drone : General, IFly
{
    public void fly()
    {
        Console.WriteLine($"{name} летает!");
    }

    public override void register()
    {
        Console.WriteLine($"Зарегестрированный {name} с айди {ID}");
    }

    public Drone(int ID, string name, double intelligence, double strength, double agility) : base(ID, name, intelligence, strength, agility)
    {
        this.property = "У него есть процессор. Он умеет летать и есть возможность на него что-то прицепить";
    }
    public override void printInfo()
    {
        Console.WriteLine($"ID:{ID}, Name:{name}, IQ:{intelligence}, Strength:{strength}, Agility:{agility}, \nОсобенность: {property}\n");
    }
}