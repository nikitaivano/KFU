class Programm
{
    static void Main(string[] args)
    {
        //1
        Student a1 = new Student();
        a1.name = "Alexey";
        a1.age = 18;
        a1.Print();

        //2
        Person p = new Person("Анна", 20);

        //3
        Book b1 = new Book();
        b1.name = "Oblomov";

        Book b2 = new Book("Pushkin");

        //4
        Person Alexey = new Person("Alexey", 18);
        Person Alexey1 = Alexey;
        Person Alesha = Alexey;
        Alexey1.name = "Alesha";


        //5

        Point po = new Point(10, 3);
        po.Print();


        //6

        Rectangle rectangle = new Rectangle();
        rectangle.w = 10;
        rectangle.h = 5;
        rectangle.GetArea();


        //7

        Balance bank = new Balance();
        bank.Add(1000);
        bank.Sub(200);


    }
}
