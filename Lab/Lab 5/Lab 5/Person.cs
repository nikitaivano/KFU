class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Я человек, меня зовут {name}");
    }
}

