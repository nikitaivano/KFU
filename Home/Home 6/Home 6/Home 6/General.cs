public abstract class General
{
    public int ID = 0;
    public string name = "Без имени";
    public double intelligence;
    public double agility;
    public double strength;

    public string property = "Нет свойств";


    public abstract void register();

    public General(int ID, string name, double intelligence, double strength, double agility)
    {
        this.ID = ID;
        this.name = name;
        this.intelligence = intelligence;
        this.strength = strength;
        this.agility = agility;
    }

    virtual public void printInfo()
    {
        Console.WriteLine($"ID:{ID}, Name:{name}, IQ:{intelligence}, Strength:{strength}, Agility:{agility}, \nОсобенность: {property}");
    }
    

}