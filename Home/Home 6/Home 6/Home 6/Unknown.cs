public class Unknown : General
{

    public override void register()
    {
        Console.WriteLine($"Зарегестрированный кто-то с айди {ID}");
    }

    public Unknown(int ID, string name, double intelligence, double strength, double agility) : base(ID, name, intelligence, strength, agility)
    {
        this.property = "Неизвестно";
    }
    public override void printInfo()
    {
        Console.WriteLine($"ID:{ID}, Name:{name}, IQ:{intelligence}, Strength:{strength}, Agility:{agility}, \nОсобенность: {property}\n");
    }
}