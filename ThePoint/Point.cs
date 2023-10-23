namespace ThePoint
{
    public class Point
    {
        public int _X { get; private set; }
        public int _Y { get; private set; }
        public Point()
        {
            _X = 0;
            _Y = 0;
        }
        public Point(int X, int Y)
        {
            _X = X;
            _Y = Y;
        }

    }
}
