using Geometry;

class Program
{
    static void Main(string[] args)
    {
        // 1
        Student a1 = new Student();
        a1.name = "Alexey";
        a1.age = 18;
        a1.Print();

        // 2
        Person p = new Person("Анна", 20);

        // 3
        Book b1 = new Book();
        b1.name = "Oblomov";

        Book b2 = new Book("Pushkin");

        // 4
        Person Alexey = new Person("Alexey", 18);
        Person Alexey1 = Alexey;
        Person Alesha = Alexey;
        Alexey1.name = "Alesha";

        // 5
        Point po = new Point(10, 3);
        po.Print();

        // 6
        Rectangle rectangle = new Rectangle();
        rectangle.w = 10;
        rectangle.h = 5;
        rectangle.GetArea();

        // 7
        Balance bank = new Balance();
        bank.Add(1000);
        bank.Sub(200);

        Console.WriteLine("Hello");

        void Test()
        {
            {
                int local = 5;
                Console.WriteLine(local);
            }
        }

        Test();

        Point geomPoint = new Point(10,20);

        Person pStud = new Student("Алексей", 18);
        pStud.Introduce();


    } // КОНЕЦ МАИНА

    class Account
    {
        private decimal balance;

        public void Deposit(decimal sum)
        {
            if (sum > 0) balance += sum;
        }
    }

    class User 
    { 
        private string password = "abc"; 
        public bool Check(string value) => password == value; 
    }

    class Animal 
    { 
        public void Eat() => Console.WriteLine("Ест"); 
    }
    class Dog : Animal 
    { 
        public void Bark() => Console.WriteLine("Гав"); 
    }


}

namespace Geometry
{
    public class Point
    {
        public int X;
        public int Y;
    }
}