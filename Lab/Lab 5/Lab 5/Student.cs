class Student : Person
{
    public Student() : base("", 0)
    {
    }

    public Student(string name, int age) : base(name, age)
    {
    }

    public void Print()
    {
        Console.WriteLine($"{name},{age}");
    }

    public override void Introduce()
    {
        Console.WriteLine($"Я студент: {name}, мне {age} лет");
    }
}