class Car
{
    private string brand;
    private string model;
    private int speed;
    private int fuel;
    private bool isEngineOn;
    private readonly int year;
    private readonly string vin;

    public Car(string brand, string model, int year, string vin)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.vin = vin;
        this.speed = 0;
        this.fuel = 0;
        this.isEngineOn = false;
    }

    public void SetFuel(int amount)
    {
        fuel += amount;

        if (fuel < 0)
        {
            fuel = 0;
        }
        else if (fuel > 100)
        {
            fuel = 100;
        }

        Console.WriteLine($"Топливо изменено. Текущий уровень: {fuel}%");
    }

    public void ToggleEngine()
    {
        if (!isEngineOn)
        {
            if (fuel > 0)
            {
                isEngineOn = true;
                Console.WriteLine("Двигатель запущен.");
            }
            else
            {
                Console.WriteLine("Нельзя запустить двигатель: нет топлива!");
            }
        }
        else
        {
            isEngineOn = false;
            speed = 0;
            Console.WriteLine("Двигатель выключен.");
        }
    }

    public void Accelerate(int addSpeed)
    {
        if (!isEngineOn)
        {
            Console.WriteLine("Сначала включите двигатель!");
            return;
        }

        if (fuel <= 0)
        {
            Console.WriteLine("Топливо закончилось, ехать нельзя!");
            return;
        }

        speed += addSpeed;

        if (speed > 180)
        {
            speed = 180;
        }

        fuel -= 5;

        if (fuel < 0)
        {
            fuel = 0;
        }

        Console.WriteLine($"Скорость увеличена. Текущая скорость: {speed} км/ч");
    }

    public void PrintStatus()
    {
        Console.WriteLine($"Автомобиль: {brand} {model}");
        Console.WriteLine($"Год: {year}, VIN: {vin}");

        if (isEngineOn)
        {
            Console.WriteLine("Двигатель: Включен");
        }
        else
        {
            Console.WriteLine("Двигатель: Выключен");
        }

        Console.WriteLine($"Скорость: {speed} км/ч");
        Console.WriteLine($"Топливо: {fuel}%");
        Console.WriteLine("\n");
    }
}