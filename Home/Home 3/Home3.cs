Console.WriteLine("1. Поиск позиции в отсортированном массиве");
Console.WriteLine("2. НОД (алгоритм Евклида)");
Console.WriteLine("3. Проверка числа на совершенность");
Console.WriteLine("4. Таблица умножения до предела");
Console.Write("\nВыбор: ");
if (int.TryParse(Console.ReadLine(), out int choice) == false)
{
    Console.WriteLine("Неверный ввод. Введите число!");
    return;
}
switch (choice)
{
    case 1:
        // Задание 1. Поиск позиции в отсортированном массиве
        Console.Write("Введите размер массива: ");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Введено не число!");
            return;
        }

        int[] mas = new int[n];
        Console.WriteLine("Введите отсортированный массив:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Элемент {i}: ");
            while (!int.TryParse(Console.ReadLine(), out mas[i]))
            {
                Console.Write("Неверный ввод. Введите число: ");
            }
        }

        Console.Write("Введите целевое число: ");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("Введено не число!");
            return;
        }

        int index = n;
        for (int i = 0; i < n; i++)
        {
            if (mas[i] >= target)
            {
                index = i;
                break;
            }
        }
        Console.WriteLine($"Индекс: {index}");
        break;

    case 2:
        // Задание 2. НОД (алгоритм Евклида)
        Console.Write("Введите первое число: ");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Введено не число!");
            return;
        }

        Console.Write("Введите второе число: ");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Введено не число!");
            return;
        }

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        Console.WriteLine($"НОД = {a}");
        break;

    case 3:
        // Задание 3. Проверка числа на совершенность
        Console.Write("Введите число: ");
        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Введено не число!");
            return;
        }

        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }
        if (sum == num && num > 1)
        {
            Console.WriteLine($"{num} — совершенное число");
        }
        else
        {
            Console.WriteLine($"{num} — не совершенное число");
        }
        break;

    case 4:
        // Задание 4. Таблица умножения до предела
        Console.Write("Введите число: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Введено не число!");
            return;
        }

        Console.Write("Введите предел: ");
        if (!int.TryParse(Console.ReadLine(), out int limit))
        {
            Console.WriteLine("Введено не число!");
            return;
        }

        for (int i = 1; i <= limit; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
        break;

    default:
        Console.WriteLine("Неверный пункт меню.");
        break;
}