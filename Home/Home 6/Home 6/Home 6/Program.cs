
class Program
{
    static void Main(string[] args)
    {
        Human Alexei = new Human(1,"Alexei",99,50,50,100);
        Alexei.walk();
        Alexei.swim();
        Alexei.speak();
        Alexei.register();
        Alexei.printInfo();


        Bird Попугай = new Bird(2, "Попугай", 30, 10, 150);
        Попугай.walk();
        Попугай.swim();
        Попугай.fly();
        Попугай.register();
        Попугай.printInfo();


        Drone DJINeo2 = new Drone(3, "DJI Neo 2", 100, 100, 100);
        DJINeo2.fly();
        DJINeo2.register();
        DJINeo2.printInfo();


        MagicBall MagBall = new MagicBall(4, "Шарик из Огня", 0, 100, 0);
        MagBall.fly();
        MagBall.register();
        MagBall.printInfo();


        MecSpider Spider = new MecSpider(5, "Опасный паук", 100, 100, 100);
        Spider.walk();
        Spider.register();
        Spider.printInfo();

        Unknown Oneone = new Unknown(6, "Кто-то", -1, -1, -1);
        Oneone.register();
        Oneone.printInfo();

    }
}