class Point
{
    public int x;
    public int y;
    public void Print()
    {
        Console.WriteLine($"{x},{y}");
    }
    public Point( int x, int y )
    {
        this.x = x; 
        this.y = y;
    }
}
