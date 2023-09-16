namespace AbduyusupovDavlatshokh01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 10);
            point.info();
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;

        }
        public void info()
        {
            Console.WriteLine($"X:{X}Y:{Y}");
        }
    }
}