class Program
{
    static void Main()
    {
        System.Console.WriteLine("Введите нечетный размер квадратной матрицы");
        //1------------------------------------------------------
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            System.Console.WriteLine("Error");
            return;
        }
        if (n % 2 == 0)
        {
            System.Console.WriteLine("Размер не нечетное");
            return;
        }
        int[,] arr = new int[n, n];
        Console.WriteLine("Напишите числа для массива");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Напишите {i},{j} элемент: ");
                if (!int.TryParse(Console.ReadLine(), out int f))
                {
                    System.Console.WriteLine("Error");
                }
                arr[i, j] = f;
            }
        }
        int stroc = arr.GetLength(0);
        int stolb = arr.GetLength(1);
        System.Console.WriteLine("Введенный массив:");
        for (int i = 0; i < stroc; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                System.Console.Write($"{arr[i, j]} ");
            }
            System.Console.WriteLine();
        }
        //2-----------------------------------------------------
        Console.WriteLine("Вывод прямого и наклонного креста");

        //Прямой крест
        ICross straight = new StraightCross();
        straight.Draw(arr);

        Console.WriteLine();


        ///Косой крест:

        ICross diagonal = new DiagonalCross();
        diagonal.Draw(arr);


        //3----------------------------------
        for (int i = 0; i < n; i++)
        {
            int maxrow = arr[i, 0];
            for (int j = 0; j < n; j++)
            {
                if (arr[i, j] > maxrow)
                {
                    maxrow = arr[i, j];
                }
            }
            Console.WriteLine($"Максимальный элемент {i + 1} строчки: {maxrow}");
        }
        //4--------------------------------
        int itog = 0;
        for (int i = 0; i < n; i++)
        {
            itog += arr[i, i];
        }
        Console.WriteLine($"Сумма главной диоганали: {itog}");
        //5---------------------------------
        int maxRowIndex = 0, maxStolIndex = 0, maxim = arr[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[i, j] > maxim)
                {
                    maxRowIndex = i;
                    maxStolIndex = j;
                    maxim = arr[i, j];
                }
            }
        }
        Console.WriteLine($"Максимальный {maxim} элемент, на координате: {maxRowIndex} {maxStolIndex} ");
    }
}