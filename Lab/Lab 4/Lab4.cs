
void SayHello()
{
    Console.WriteLine("Привет студент");
    Console.WriteLine("Привет студент");
    Console.WriteLine("Привет студент");
}

void Square(int x)
{
    Console.WriteLine(x*x);
}

void Average(params double[] numbers)
{
    double result = 0;
    foreach (double n in numbers)
        result += n;
    Console.WriteLine(result/numbers.Length);
}

void Calculate(int x, string o, int y)
{
    if (o == "+")
    {
        Console.WriteLine(x+y);
    }

    else if (o=="*")
    {
        Console.WriteLine(x*y);
    }
    else if (o=="/")
    {
        if(y == 0)
        {
            Console.WriteLine("На 0 делить нельзя");
            return;
        }
        Console.WriteLine((double)x / y);
    }
    else if (o=="-")
    {
        Console.WriteLine(x-y);
    }
    else
    {
        Console.WriteLine("Неизвестная операция");
    }
}

void MinMax(out int min, out int max, params int[] mas)
{
    min = mas[0];
    max = mas[0];
    foreach (int n in mas)
    {
        if (max<n)
        {
            max = n;
        }
        if (min>n)
        {
            min = n;
        }
    }
    Console.WriteLine($"Мин: {min}, Макс: {max}");
}


Console.WriteLine("Напишите что вы хотите сделать? \n 1-Написать 'Привет студент' 3 раза \n 2-Узнать квадрат числа \n 3-Узнать среднее арифметическое чисел \n 4-Дешевый калькулятор \n 5-Мин и макс массива");
if (int.TryParse(Console.ReadLine(), out int choice) == false)
{
    Console.WriteLine("Неверный ввод. Введите число!");
    return;
}

switch(choice)
{
    case 1:
        {
            //Привет студент
            SayHello();
        }
        break;
    case 2:
        {
            Console.Write("Напишите число: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Square(num);
            }
        }
        break;
    case 3:
        {
            Console.Write("Введите размер массива: ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Введено не число!");
                return;
            }
            
            
            double[] mas = new double[n];
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент {i+1}: ");
                while (!double.TryParse(Console.ReadLine(), out mas[i]))
                {
                    Console.Write("Неверный ввод. Введите число: ");
                }
            }
            
            Average(mas);
        }
        break;
    case 4:
        {
            Console.Write("Напишите 1 элемент: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Введено не число!");
                return;
            }

            Console.Write("Напишите 2 элемент: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Введено не число!");
                return;
            }

            Console.Write("Напишите операцию(+ - * /) на выбор: ");
            string o = Console.ReadLine();
            Calculate(a,o,b);
        }
        break;
    case 5:
        {
            Console.Write("Введите размер массива: ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Введено не число!");
                return;
            }
            
            
            int[] mas = new int[n];
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент {i+1}: ");
                while (!int.TryParse(Console.ReadLine(), out mas[i]))
                {
                    Console.Write("Неверный ввод. Введите число: ");
                }
            }
            MinMax(out int min, out int max, mas);
        }
        break;
}