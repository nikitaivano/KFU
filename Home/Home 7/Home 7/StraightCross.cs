class StraightCross : ICross
{
    public void Draw(int[,] arr)
    {
        int n = arr.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == n / 2 || j == n / 2)
                {
                    Console.Write($" {arr[i, j]} ");
                }
                else
                {
                    Console.Write(" * ");
                }
            }

            Console.WriteLine();
        }
    }
}